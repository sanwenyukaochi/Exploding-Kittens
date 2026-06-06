package com.kittens.exploding.game.domain.card;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CardCategory {
    DEFUSE("Defuse"),
    BOMB("Bomb"),
    SKIP("Skip"),
    SHUFFLE("Shuffle"),
    STEAL("Steal"),
    DRAW_FROM_BOTTOM("DrawFromBottom"),
    REVERSE("Reverse"),
    CHICKEN_PARTY("ChickenParty"),
    DIARRHEA_1("Diarrhea1"),
    DIARRHEA_2("Diarrhea2"),
    SLAP_1("Slap1"),
    SLAP_2("Slap2"),
    SLAP_3("Slap3"),
    ATTACK_CAT_BUTT("AttackCatButt"),
    FUTURE_1("Future1"),
    FUTURE_3("Future3"),
    FUTURE_5("Future5"),
    ALTER_2("Alter2"),
    ALTER_3("Alter3"),
    ALTER_5("Alter5"),
    FAKE_SHUFFLE("FakeShuffle"),
    KITTEN_ROLL_CALL("KittenRollCall"),
    SELF_SLAP_2("SelfSlap2"),
    SELF_SLAP_3("SelfSlap3"),
    NONE("None"),
    STREAKING_KITTEN("StreakingKitten"),
    SUPER_SKIP("SuperSkip"),
    SWAP_TOP_BOTTOM("SwapTopBottom"),
    CATOMIC_BOMB("CatomicBomb"),
    GARBAGE_COLLECTION("GarbageCollection"),
    MARK("Mark"),
    BARKING_KITTEN("BarkingKitten"),
    TAKE_THAT("TakeThat"),
    BURY("Bury"),
    POT_LUCK("PotLuck"),
    TOWER_OF_POWER("TowerOfPower"),
    SHARE_THE_FUTURE("ShareTheFuture"),
    ;

    private final String value;

}