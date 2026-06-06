package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum PhotonNetworkingMessage {
    ON_CONNECTED_TO_PHOTON("OnConnectedToPhoton"),
    ON_LEFT_ROOM("OnLeftRoom"),
    ON_MASTER_CLIENT_SWITCHED("OnMasterClientSwitched"),
    ON_PHOTON_CREATE_ROOM_FAILED("OnPhotonCreateRoomFailed"),
    ON_PHOTON_JOIN_ROOM_FAILED("OnPhotonJoinRoomFailed"),
    ON_CREATED_ROOM("OnCreatedRoom"),
    ON_JOINED_LOBBY("OnJoinedLobby"),
    ON_LEFT_LOBBY("OnLeftLobby"),
    ON_DISCONNECTED_FROM_PHOTON("OnDisconnectedFromPhoton"),
    ON_CONNECTION_FAIL("OnConnectionFail"),
    ON_FAILED_TO_CONNECT_TO_PHOTON("OnFailedToConnectToPhoton"),
    ON_RECEIVED_ROOM_LIST_UPDATE("OnReceivedRoomListUpdate"),
    ON_JOINED_ROOM("OnJoinedRoom"),
    ON_PHOTON_PLAYER_CONNECTED("OnPhotonPlayerConnected"),
    ON_PHOTON_PLAYER_DISCONNECTED("OnPhotonPlayerDisconnected"),
    ON_PHOTON_RANDOM_JOIN_FAILED("OnPhotonRandomJoinFailed"),
    ON_CONNECTED_TO_MASTER("OnConnectedToMaster"),
    ON_PHOTON_SERIALIZE_VIEW("OnPhotonSerializeView"),
    ON_PHOTON_INSTANTIATE("OnPhotonInstantiate"),
    ON_PHOTON_MAX_CCCU_REACHED("OnPhotonMaxCccuReached"),
    ON_PHOTON_CUSTOM_ROOM_PROPERTIES_CHANGED("OnPhotonCustomRoomPropertiesChanged"),
    ON_PHOTON_PLAYER_PROPERTIES_CHANGED("OnPhotonPlayerPropertiesChanged"),
    ON_UPDATED_FRIEND_LIST("OnUpdatedFriendList"),
    ON_CUSTOM_AUTHENTICATION_FAILED("OnCustomAuthenticationFailed"),
    ON_CUSTOM_AUTHENTICATION_RESPONSE("OnCustomAuthenticationResponse"),
    ON_WEB_RPC_RESPONSE("OnWebRpcResponse"),
    ON_OWNERSHIP_REQUEST("OnOwnershipRequest"),
    ON_LOBBY_STATISTICS_UPDATE("OnLobbyStatisticsUpdate"),
    ON_PHOTON_PLAYER_ACTIVITY_CHANGED("OnPhotonPlayerActivityChanged"),
    ON_OWNERSHIP_TRANSFERED("OnOwnershipTransfered");

    private final String value;
}