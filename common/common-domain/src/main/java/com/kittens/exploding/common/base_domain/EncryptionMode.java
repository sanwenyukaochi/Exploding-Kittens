package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum EncryptionMode {
    PAYLOAD_ENCRYPTION("PayloadEncryption"),
    DATAGRAM_ENCRYPTION("DatagramEncryption");

    private final String value;
}