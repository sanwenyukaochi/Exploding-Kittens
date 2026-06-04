package com.kittens.exploding.rabbit.producer.service.impl;

import com.kittens.exploding.rabbit.producer.service.RabbitProducer;
import java.io.Serializable;
import java.util.function.BiConsumer;

import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.amqp.AmqpException;
import org.springframework.amqp.core.MessageProperties;
import org.springframework.amqp.rabbit.connection.CorrelationData;
import org.springframework.amqp.rabbit.core.RabbitTemplate;
import org.springframework.stereotype.Component;

@Slf4j
@Component
@RequiredArgsConstructor
public class RabbitProducerImpl<T extends Serializable> implements RabbitProducer<T> {

    private final RabbitTemplate rabbitTemplate;

    @Override
    public void convertAndSend(String exchange, String routingKey, String messageId, T message, BiConsumer<CorrelationData.Confirm, Throwable> callback) {
        try {
            log.info("Sending rabbit message, exchange={}, routingKey={}, messageId={}, message={}", exchange, routingKey, messageId, message);
            CorrelationData correlationData = new CorrelationData(messageId);
            correlationData.getFuture().whenComplete(callback);
            rabbitTemplate.convertAndSend(exchange, routingKey, message, rabbitMessage -> {
                        rabbitMessage.getMessageProperties().setMessageId(messageId);
                        rabbitMessage.getMessageProperties().setContentType(MessageProperties.CONTENT_TYPE_JSON);
                        return rabbitMessage;
                    },
                    correlationData
            );
        } catch (AmqpException e) {
            log.error("Error on rabbit producer, routingKey={}, message={}", routingKey, message, e);
            throw new RuntimeException(
                    "Error on rabbit producer with routingKey: " + routingKey + ", message: " + message, e
            );
        }
    }
}
