package io.kittens.exploding.player.domain.valueObject;

public enum PlayerPhase {
    WaitingForTurn,
    MyTurn,
    Defusing,
    Dead,
    Won,
    AwaitingSteal,
    ChoosingOpponent,
    ChoosingCardToGive,
    SeeingFuture,
    AlteringFuture,
    SeeingShareFuture,
    BuryCard,
    AwaitingOpponentDefuse,
    Never
}
