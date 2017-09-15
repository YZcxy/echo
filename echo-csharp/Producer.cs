using System;
using Apache.NMS;
using Apache.NMS.ActiveMQ;

namespace echo_csharp
{
    public static class Producer
    {
        public static void proHandler()
        {
            //相关配置
            String user = "admin";
            String password = "admin";
            String host = "127.0.0.1";
            int port = 61616;
            String destination = "sample.queue";
            String brokerUri = "activemq:tcp://" + host + ":" + port;

             //根据URI创建NMS连接工厂
            NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);
            //根据用户名密码创建连接
            IConnection connection = factory.CreateConnection(user, password);
            //打开连接
	        connection.Start();
            //创建Session
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
	        //根据destination创建主题
            IDestination dest = session.GetQueue(destination);
            //创建生产者
	        IMessageProducer producer = session.CreateProducer(dest);
            producer.DeliveryMode = MsgDeliveryMode.NonPersistent;
            //发送消息
            String body = "hello,javaJMS!!  I'm C#";
            producer.Send(session.CreateTextMessage(body));
            //关闭连接
	        connection.Close();
        }
    }
}