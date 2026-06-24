package com.kittens.exploding.rabbit.config.data;

import lombok.Data;

import org.springframework.boot.context.properties.ConfigurationProperties;
import org.springframework.context.annotation.Configuration;

@Data
@Configuration
@ConfigurationProperties(prefix = "rabbit-config")
public class RabbitConfigData {
    private String host;
    private Integer port;
    private String username;
    private String password;
    private String virtualHost;
    private String publisherConfirmType;
    private Boolean publisherReturns;
}
