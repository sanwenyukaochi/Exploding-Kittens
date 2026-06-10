package com.kittens.exploding.rabbit.config.data;

import java.util.Locale;
import lombok.RequiredArgsConstructor;
import org.springframework.amqp.rabbit.connection.CachingConnectionFactory;
import org.springframework.amqp.rabbit.connection.ConnectionFactory;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
@RequiredArgsConstructor
public class RabbitConfig {

    private final RabbitConfigData rabbitConfigData;

    @Bean
    public ConnectionFactory rabbitConnectionFactory() {
        CachingConnectionFactory connectionFactory = new CachingConnectionFactory();
        if (rabbitConfigData.getHost() != null) {
            connectionFactory.setHost(rabbitConfigData.getHost());
        }
        if (rabbitConfigData.getPort() != null) {
            connectionFactory.setPort(rabbitConfigData.getPort());
        }
        if (rabbitConfigData.getUsername() != null) {
            connectionFactory.setUsername(rabbitConfigData.getUsername());
        }
        if (rabbitConfigData.getPassword() != null) {
            connectionFactory.setPassword(rabbitConfigData.getPassword());
        }
        if (rabbitConfigData.getVirtualHost() != null) {
            connectionFactory.setVirtualHost(rabbitConfigData.getVirtualHost());
        }

        if (rabbitConfigData.getPublisherConfirmType() != null) {
            connectionFactory.setPublisherConfirmType(
                    CachingConnectionFactory.ConfirmType.valueOf(
                            rabbitConfigData
                                    .getPublisherConfirmType()
                                    .trim()
                                    .toUpperCase(Locale.ROOT)));
        }
        if (rabbitConfigData.getPublisherReturns() != null) {
            connectionFactory.setPublisherReturns(rabbitConfigData.getPublisherReturns());
        }

        return connectionFactory;
    }
}
