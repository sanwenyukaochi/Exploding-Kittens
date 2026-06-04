package com.kittens.exploding.rabbit.consumer.config;

import com.kittens.exploding.rabbit.config.data.RabbitConsumerConfigData;
import java.util.Locale;
import org.springframework.amqp.core.AcknowledgeMode;
import org.springframework.amqp.rabbit.config.SimpleRabbitListenerContainerFactory;
import org.springframework.amqp.rabbit.connection.ConnectionFactory;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class RabbitConsumerConfig {

    private final RabbitConsumerConfigData rabbitConsumerConfigData;

    public RabbitConsumerConfig(RabbitConsumerConfigData rabbitConsumerConfigData) {
        this.rabbitConsumerConfigData = rabbitConsumerConfigData;
    }

    @Bean
    public SimpleRabbitListenerContainerFactory rabbitListenerContainerFactory(
            ConnectionFactory rabbitConnectionFactory) {
        SimpleRabbitListenerContainerFactory factory = new SimpleRabbitListenerContainerFactory();
        factory.setConnectionFactory(rabbitConnectionFactory);

        if (rabbitConsumerConfigData.getAcknowledgeMode() != null) {
            factory.setAcknowledgeMode(
                    AcknowledgeMode.valueOf(
                            rabbitConsumerConfigData.getAcknowledgeMode().trim().toUpperCase(Locale.ROOT)));
        }
        if (rabbitConsumerConfigData.getAutoStartup() != null) {
            factory.setAutoStartup(rabbitConsumerConfigData.getAutoStartup());
        }
        if (rabbitConsumerConfigData.getConcurrentConsumers() != null) {
            factory.setConcurrentConsumers(rabbitConsumerConfigData.getConcurrentConsumers());
        }
        if (rabbitConsumerConfigData.getMaxConcurrentConsumers() != null) {
            factory.setMaxConcurrentConsumers(rabbitConsumerConfigData.getMaxConcurrentConsumers());
        }
        if (rabbitConsumerConfigData.getPrefetchCount() != null) {
            factory.setPrefetchCount(rabbitConsumerConfigData.getPrefetchCount());
        }
        if (rabbitConsumerConfigData.getDefaultRequeueRejected() != null) {
            factory.setDefaultRequeueRejected(rabbitConsumerConfigData.getDefaultRequeueRejected());
        }

        return factory;
    }
}
