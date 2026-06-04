package com.kittens.exploding.rabbit.producer.service;

import org.springframework.amqp.rabbit.connection.CorrelationData;

import java.io.Serializable;
import java.util.function.BiConsumer;

public interface RabbitProducer<T extends Serializable> {
    void convertAndSend(String exchange, String routingKey, String messageId, T message, BiConsumer<CorrelationData.Confirm, Throwable> callback
    );
}
