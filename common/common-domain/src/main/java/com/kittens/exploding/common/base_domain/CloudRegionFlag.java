package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CloudRegionFlag {
    EU("1"),
    US("2"),
    ASIA("4"),
    JP("8"),
    AU("16"),
    USW("32"),
    SA("64"),
    CAE("128"),
    KR("256"),
    IN("512"),
    RU("1024"),
    RUE("2048");

    private final String value;
}