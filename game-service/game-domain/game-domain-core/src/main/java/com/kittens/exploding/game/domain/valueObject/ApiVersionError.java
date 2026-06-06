package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ApiVersionError {
    ROOM_HAS_NEWER_API_VERSION("RoomHasNewerApiVersion"),
    ROOM_HAS_OLDER_API_VERSION("RoomHasOlderApiVersion");

    private final String value;

}