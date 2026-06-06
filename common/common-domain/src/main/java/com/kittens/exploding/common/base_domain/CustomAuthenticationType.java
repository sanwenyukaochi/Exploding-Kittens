package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CustomAuthenticationType {
    CUSTOM("Custom"),
    STEAM("Steam"),
    FACEBOOK("Facebook"),
    OCULUS("Oculus"),
    PLAY_STATION("PlayStation"),
    XBOX("Xbox"),
    NONE("None");

    private final String value;
}