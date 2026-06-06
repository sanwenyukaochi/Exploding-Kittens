package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum OwnershipOption {
    FIXED("Fixed"),
    TAKEOVER("Takeover"),
    REQUEST("Request");

    private final String value;
}