package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum AuthModeOption {
    AUTH("Auth"),
    AUTH_ONCE("AuthOnce"),
    AUTH_ONCE_WSS("AuthOnceWss");

    private final String value;
}