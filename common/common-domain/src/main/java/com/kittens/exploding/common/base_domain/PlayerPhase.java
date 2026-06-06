package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum PlayerPhase {
    WAITING_FOR_TURN("WaitingForTurn"),
    MY_TURN("MyTurn"),
    DEFUSING("Defusing"),
    DEAD("Dead"),
    WON("Won"),
    AWAITING_STEAL("AwaitingSteal"),
    CHOOSING_OPPONENT("ChoosingOpponent"),
    CHOOSING_CARD_TO_GIVE("ChoosingCardToGive"),
    SEEING_FUTURE("SeeingFuture"),
    ALTERING_FUTURE("AlteringFuture"),
    SEEING_SHARE_FUTURE("SeeingShareFuture"),
    BURY_CARD("BuryCard"),
    AWAITING_OPPONENT_DEFUSE("AwaitingOpponentDefuse"),
    NEVER("Never");

    private final String value;
}