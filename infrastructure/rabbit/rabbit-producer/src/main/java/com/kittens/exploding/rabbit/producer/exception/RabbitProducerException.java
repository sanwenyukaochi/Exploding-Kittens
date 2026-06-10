package com.kittens.exploding.rabbit.producer.exception;

public class RabbitProducerException extends RuntimeException {

    public RabbitProducerException(String message, Throwable cause) {
        super(message, cause);
    }
}
