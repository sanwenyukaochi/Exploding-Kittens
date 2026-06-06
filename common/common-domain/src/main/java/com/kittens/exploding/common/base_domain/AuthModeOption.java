package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum AuthModeOption {
    AUTH("Auth"),
    AUTH_ONCE("AuthOnce"),
    AUTH_ONCE_WSS("AuthOnceWss");

    private final String value;
}