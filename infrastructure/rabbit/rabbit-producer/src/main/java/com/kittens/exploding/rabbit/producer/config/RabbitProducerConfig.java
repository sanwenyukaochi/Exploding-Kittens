package com.kittens.exploding.rabbit.producer.config;

import com.kittens.exploding.rabbit.config.data.RabbitProducerConfigData;

import lombok.RequiredArgsConstructor;

import org.springframework.amqp.rabbit.connection.ConnectionFactory;
import org.springframework.amqp.rabbit.core.RabbitTemplate;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
@RequiredArgsConstructor
public class RabbitProducerConfig {

    private final RabbitProducerConfigData rabbitProducerConfigData;

    @Bean
    public RabbitTemplate rabbitTemplate(ConnectionFactory rabbitConnectionFactory) {
        RabbitTemplate rabbitTemplate = new RabbitTemplate(rabbitConnectionFactory);
        if (rabbitProducerConfigData.getMandatory() != null) {
            rabbitTemplate.setMandatory(rabbitProducerConfigData.getMandatory());
        }
        return rabbitTemplate;
    }
}
