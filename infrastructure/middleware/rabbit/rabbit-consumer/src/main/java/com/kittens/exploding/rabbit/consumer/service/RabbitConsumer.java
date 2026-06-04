package com.kittens.exploding.rabbit.consumer.service;

import java.io.Serializable;

public interface RabbitConsumer<T extends Serializable> {
    void receive(T message);
}
