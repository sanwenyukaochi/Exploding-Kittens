package com.kittens.exploding.rabbit.producer.service;

import java.io.Serializable;
import java.util.function.BiConsumer;
import org.springframework.amqp.rabbit.connection.CorrelationData;

public interface RabbitProducer<T extends Serializable> {
    void convertAndSend(
            String exchange,
            String routingKey,
            String messageId,
            T message,
            BiConsumer<CorrelationData.Confirm, Throwable> callback);
}
