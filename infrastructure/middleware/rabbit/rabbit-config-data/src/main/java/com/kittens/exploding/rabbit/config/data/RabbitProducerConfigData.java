package com.kittens.exploding.rabbit.config.data;

import lombok.Data;
import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.context.annotation.Configuration;

@Data
@Configuration
@ConfigurationProperties(prefix = "rabbit-producer-config")
public class RabbitProducerConfigData {
    private Boolean mandatory;
}
