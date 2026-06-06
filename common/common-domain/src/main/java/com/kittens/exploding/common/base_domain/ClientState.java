package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ClientState {
    UNINITIALIZED("Uninitialized"),
    PEER_CREATED("PeerCreated"),
    QUEUED("Queued"),
    AUTHENTICATED("Authenticated"),
    JOINED_LOBBY("JoinedLobby"),
    DISCONNECTING_FROM_MASTERSERVER("DisconnectingFromMasterserver"),
    CONNECTING_TO_GAMESERVER("ConnectingToGameserver"),
    CONNECTED_TO_GAMESERVER("ConnectedToGameserver"),
    JOINING("Joining"),
    JOINED("Joined"),
    LEAVING("Leaving"),
    DISCONNECTING_FROM_GAMESERVER("DisconnectingFromGameserver"),
    CONNECTING_TO_MASTERSERVER("ConnectingToMasterserver"),
    QUEUED_COMING_FROM_GAMESERVER("QueuedComingFromGameserver"),
    DISCONNECTING("Disconnecting"),
    DISCONNECTED("Disconnected"),
    CONNECTED_TO_MASTER("ConnectedToMaster"),
    CONNECTING_TO_NAME_SERVER("ConnectingToNameServer"),
    CONNECTED_TO_NAME_SERVER("ConnectedToNameServer"),
    DISCONNECTING_FROM_NAME_SERVER("DisconnectingFromNameServer"),
    AUTHENTICATING("Authenticating");

    private final String value;
}