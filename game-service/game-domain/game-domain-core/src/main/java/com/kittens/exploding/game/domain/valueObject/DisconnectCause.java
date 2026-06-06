package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DisconnectCause {
    DISCONNECT_BY_SERVER_USER_LIMIT("DisconnectByServerUserLimit"),
    EXCEPTION_ON_CONNECT("ExceptionOnConnect"),
    DISCONNECT_BY_SERVER_TIMEOUT("DisconnectByServerTimeout"),
    DISCONNECT_BY_SERVER_LOGIC("DisconnectByServerLogic"),
    EXCEPTION("Exception"),
    INVALID_AUTHENTICATION("InvalidAuthentication"),
    MAX_CCU_REACHED("MaxCcuReached"),
    INVALID_REGION("InvalidRegion"),
    SECURITY_EXCEPTION_ON_CONNECT("SecurityExceptionOnConnect"),
    DISCONNECT_BY_CLIENT_TIMEOUT("DisconnectByClientTimeout"),
    INTERNAL_RECEIVE_EXCEPTION("InternalReceiveException"),
    AUTHENTICATION_TICKET_EXPIRED("AuthenticationTicketExpired");

    private final String value;
}