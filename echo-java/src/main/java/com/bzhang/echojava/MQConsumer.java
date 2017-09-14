package com.bzhang.echojava;

import org.springframework.jms.annotation.JmsListener;
import org.springframework.stereotype.Component;

@Component
public class MQConsumer {

    @JmsListener(destination = "sample.queue")
    public void receiveQueue(String test){
        System.out.println(test);
    }
}
