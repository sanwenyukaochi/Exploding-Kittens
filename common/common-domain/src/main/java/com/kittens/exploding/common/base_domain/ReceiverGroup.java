package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum ReceiverGroup {
    OTHERS("Others"),
    ALL("All"),
    MASTER_CLIENT("MasterClient");

    private final String value;
}