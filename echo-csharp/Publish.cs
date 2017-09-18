using System;
using Apache.NMS;
using Apache.NMS.Stomp;

namespace echo_csharp
{
    public static class Publish
    {
        public static void pubHandler()
        {
            //相关配置
            String user = "admin";
	        String password = "admin";
	        String host = "127.0.0.1";
	        int port = 61613;
			String destination = "test.general";
            String brokerUri = "stomp:tcp://" + host + ":" + port;

            //根据URI创建NMS连接工厂
            NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);
            //根据用户名密码创建连接
            IConnection connection = factory.CreateConnection(user, password);
            //打开连接
	        connection.Start();
            //创建Session
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
	        //根据destination创建主题
            IDestination dest = session.GetTopic(destination);
            //创建生产者
	        IMessageProducer producer = session.CreateProducer(dest);
            producer.DeliveryMode = MsgDeliveryMode.NonPersistent;
            //发送消息
            var body = CreateMessage.doCreate();
            producer.Send(session.CreateTextMessage(body));
            //关闭连接
	        connection.Close();
        }
    }
}