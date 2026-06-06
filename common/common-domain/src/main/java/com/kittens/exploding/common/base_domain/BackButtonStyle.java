package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum BackButtonStyle {
    BACK("Back"),
    CANCEL("Cancel");

    private final String value;
}