package com.bzhang.echojava;

import com.alibaba.fastjson.JSON;
import com.bzhang.entity.Info;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.stereotype.Component;

import javax.jms.JMSException;
import javax.jms.TextMessage;

@Component
public class MQConsumer {

    @JmsListener(destination = "sample.queue")
    public void receiveQueue(TextMessage textMessage) throws JMSException {
        String message = textMessage.getText();
        Info info = JSON.parseObject(message, Info.class);
        System.out.println(info.toString());
    }
}
