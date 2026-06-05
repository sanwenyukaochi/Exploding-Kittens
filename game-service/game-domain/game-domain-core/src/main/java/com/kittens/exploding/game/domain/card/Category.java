package com.kittens.exploding.game.domain.card;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum Category {
    ALTER2("Alter2"),
    ALTER3("Alter3"),
    ALTER5("Alter5"),
    ATTACK_CAT_BUTT("AttackCatButt"),
    BARKING_KITTEN("BarkingKitten"),
    BOMB("Bomb"),
    BURY("Bury"),
    CATOMIC_BOMB("CatomicBomb"),
    DEFUSE("Defuse"),
    DIARRHEA1("Diarrhea1"),
    DIARRHEA2("Diarrhea2"),
    DRAW_FROM_BOTTOM("DrawFromBottom"),
    FAKE_SHUFFLE("FakeShuffle"),
    FUTURE1("Future1"),
    FUTURE3("Future3"),
    FUTURE5("Future5"),
    GARBAGE_COLLECTION("GarbageCollection"),
    POT_LUCK("PotLuck"),
    REVERSE("Reverse"),
    SELF_SLAP2("SelfSlap2"),
    SELF_SLAP3("SelfSlap3"),
    SHARE_THE_FUTURE("ShareTheFuture"),
    SHUFFLE("Shuffle"),
    SKIP("Skip"),
    SLAP1("Slap1"),
    SLAP2("Slap2"),
    SLAP3("Slap3"),
    STEAL("Steal"),
    STREAKING_KITTEN("StreakingKitten"),
    SUPER_SKIP("SuperSkip"),
    SWAP_TOP_BOTTOM("SwapTopBottom"),
    TAKE_THAT("TakeThat"),
    TOWER_OF_POWER("TowerOfPower");

    private final String code;


}