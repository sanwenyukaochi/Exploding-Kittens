package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CloudRegionCode {
    EU("eu"),
    US("us"),
    ASIA("asia"),
    JP("jp"),
    AU("au"),
    USW("usw"),
    SA("sa"),
    CAE("cae"),
    KR("kr"),
    IN("in"),
    RU("ru"),
    RUE("rue"),
    NONE("none");

    private final String value;
}