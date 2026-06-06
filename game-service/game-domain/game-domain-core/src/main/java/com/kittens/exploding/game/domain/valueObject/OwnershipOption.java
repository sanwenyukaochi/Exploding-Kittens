package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum OwnershipOption {
    FIXED("Fixed"),
    TAKEOVER("Takeover"),
    REQUEST("Request");

    private final String value;
}