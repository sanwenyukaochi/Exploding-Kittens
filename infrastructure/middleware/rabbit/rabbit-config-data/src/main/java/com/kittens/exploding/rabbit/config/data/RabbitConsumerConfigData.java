package com.kittens.exploding.rabbit.config.data;

import lombok.Data;
import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.context.annotation.Configuration;

@Data
@Configuration
@ConfigurationProperties(prefix = "rabbit-consumer-config")
public class RabbitConsumerConfigData {
    private String acknowledgeMode;
    private Boolean autoStartup;
    private Integer concurrentConsumers;
    private Integer maxConcurrentConsumers;
    private Integer prefetchCount;
    private Boolean defaultRequeueRejected;
}
