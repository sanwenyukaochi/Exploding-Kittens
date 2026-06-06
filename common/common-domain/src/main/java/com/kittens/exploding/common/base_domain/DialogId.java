package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DialogId {
    RESTORE_PURCHASES_SUCCESS("RestorePurchasesSuccess"),
    RESTORE_PURCHASES_FAILURE("RestorePurchasesFailure"),
    IAP_NOT_SUPPORTED("IapNotSupported"),
    AVATAR_PACK_PURCHASE_SUCCESS("AvatarPackPurchaseSuccess"),
    AVATAR_PACK_PURCHASE_FAILURE("AvatarPackPurchaseFailure"),
    JOIN_GAME_VERSION_FAILURE("JoinGameVersionFailure"),
    EXPANSION_DECK_PURCHASE_SUCCESS("ExpansionDeckPurchaseSuccess"),
    EXPANSION_DECK_PURCHASE_FAILURE("ExpansionDeckPurchaseFailure"),
    JOIN_GAME_HANDSHAKE_ERROR("JoinGameHandshakeError"),
    NO_PLAYERS_FOUND_ERROR("NoPlayersFoundError"),
    PHOTON_NETWORK_DOWN_ERROR("PhotonNetworkDownError"),
    HOST_LEFT_LOBBY_ERROR("HostLeftLobbyError"),
    WIZARD_MODE_UNLOCKED_DIALOG("WizardModeUnlockedDialog"),
    WRONG_PASSWORD_DIALOG("WrongPasswordDialog"),
    PURCHASE_ITEM_ALREADY_OWNED("PurchaseItemAlreadyOwned"),
    YOU_ARE_ALL_ALONE_ERROR("YouAreAllAloneError"),
    INVALID_CODE_ENTERED_ERROR("InvalidCodeEnteredError"),
    CODE_ALREADY_ENTERED("CodeAlreadyEntered"),
    PHOTON_CCU_LIMIT_REACHED("PhotonCcuLimitReached");

    private final String value;
}