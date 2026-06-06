package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum PhotonTargets {
    ALL("All"),
    OTHERS("Others"),
    MASTER_CLIENT("MasterClient"),
    ALL_BUFFERED("AllBuffered"),
    OTHERS_BUFFERED("OthersBuffered"),
    ALL_VIA_SERVER("AllViaServer"),
    ALL_BUFFERED_VIA_SERVER("AllBufferedViaServer");

    private final String value;
}