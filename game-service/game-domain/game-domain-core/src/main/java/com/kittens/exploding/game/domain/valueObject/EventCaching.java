package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum EventCaching {
    DO_NOT_CACHE("DoNotCache"),
    @Deprecated
    MERGE_CACHE("MergeCache"),
    @Deprecated
    REPLACE_CACHE("ReplaceCache"),
    @Deprecated
    REMOVE_CACHE("RemoveCache"),
    ADD_TO_ROOM_CACHE("AddToRoomCache"),
    ADD_TO_ROOM_CACHE_GLOBAL("AddToRoomCacheGlobal"),
    REMOVE_FROM_ROOM_CACHE("RemoveFromRoomCache"),
    REMOVE_FROM_ROOM_CACHE_FOR_ACTORS_LEFT("RemoveFromRoomCacheForActorsLeft"),
    SLICE_INCREASE_INDEX("SliceIncreaseIndex"),
    SLICE_SET_INDEX("SliceSetIndex"),
    SLICE_PURGE_INDEX("SlicePurgeIndex"),
    SLICE_PURGE_UP_TO_INDEX("SlicePurgeUpToIndex");

    private final String value;
}