package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum RematchGamePlayerState {
    WAITING_ON_RESPONSE("WaitingOnResponse"),
    ACCEPTED("Accepted"),
    DECLINED("Declined");

    private final String value;
}