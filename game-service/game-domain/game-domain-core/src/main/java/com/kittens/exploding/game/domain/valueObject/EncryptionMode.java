package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum EncryptionMode {
    PAYLOAD_ENCRYPTION("PayloadEncryption"),
    DATAGRAM_ENCRYPTION("DatagramEncryption");

    private final String value;
}