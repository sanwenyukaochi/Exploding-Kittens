package com.kittens.exploding.game.domain.card;

import lombok.Getter;
import lombok.RequiredArgsConstructor;

@Getter
@RequiredArgsConstructor
public enum TextureFilename {
    ANNOY_DIARRHEA1("Annoy.Diarrhea1", Category.DIARRHEA1, null),
    ANNOY_DIARRHEA2("Annoy.Diarrhea2", Category.DIARRHEA2, null),
    ATF_FURMAID("ATF.Furmaid", Category.ALTER2, JukeboxId.CARD_ATF_FURMAID),
    ATF_MANATEE("ATF.Manatee", Category.ALTER3, JukeboxId.CARD_ATF_MANATEE),
    ATF_TESLA("ATF.Tesla", Category.ALTER5, JukeboxId.CARD_ATF_TESLA),
    ATTACK_CAT_BUTT("Attack.CatButt", Category.ATTACK_CAT_BUTT, JukeboxId.CARD_ATTACK_CAT_BUTT),
    BARKING_KITTEN("BarkingKitten", Category.BARKING_KITTEN, JukeboxId.CARD_BARKING_KITTEN),
    BOMB_KITTEN("bomb.kitten", Category.BOMB, null),
    BURY("Bury", Category.BURY, JukeboxId.CARD_BURY),
    CATOMIC_BOMB("CatomicBomb", Category.CATOMIC_BOMB, JukeboxId.CARD_CATOMIC_BOMB),
    DEFUSE_BANJO("Defuse.Banjo", Category.DEFUSE, JukeboxId.CARD_DEFUSE_BANJO),
    DEFUSE_CATNIP("Defuse.Catnip", Category.DEFUSE, JukeboxId.CARD_DEFUSE_CATNIP),
    DEFUSE_LASER("Defuse.Laser", Category.DEFUSE, JukeboxId.CARD_DEFUSE_LASER),
    DFB("DFB", Category.DRAW_FROM_BOTTOM, JukeboxId.CARD_DFB),
    FAKE_SHUFFLE("Fake.Shuffle", Category.FAKE_SHUFFLE, JukeboxId.CARD_SHUFFLE),
    GARBAGE_COLLECTION("GarbageCollection", Category.GARBAGE_COLLECTION, JukeboxId.CARD_GARBAGE_TRUCK_BACKING_UP),
    POT_LUCK_A("PotLuckA", Category.POT_LUCK, JukeboxId.CARD_POTLUCK),
    REVERSE_BACKWARDS("Reverse.Backwards", Category.REVERSE, JukeboxId.CARD_REVERSE_ENGINE),
    REVERSE_SIR_SCRATCH("Reverse.SirScratch", Category.REVERSE, JukeboxId.CARD_REVERSE_SIR_SCRATCH),
    SHARE_THE_FUTURE("ShareTheFuture", Category.SHARE_THE_FUTURE, JukeboxId.CARD_SHARE_THE_FUTURE),
    SHUFFLE_LITTERBOX("Shuffle.Litterbox", Category.SHUFFLE, JukeboxId.CARD_SHUFFLE),
    SKIP_BUNNYRAPTOR("Skip.Bunnyraptor", Category.SKIP, JukeboxId.CARD_SKIP_BUNNYRAPTOR),
    SKIP_NAP("Skip.Nap", Category.SKIP, JukeboxId.CARD_SKIP_NAP),
    SKIP_SPRINT("Skip.Sprint", Category.SKIP, JukeboxId.CARD_SKIP_SPRINT),
    SLAP_1("Slap.1", Category.SLAP1, null),
    SLAP_2("Slap.2", Category.SLAP2, null),
    SLAP_3("Slap.3", Category.SLAP3, null),
    SLAP_SELF2("Slap.Self2", Category.SELF_SLAP2, null),
    SLAP_SELF3("Slap.Self3", Category.SELF_SLAP3, null),
    STEAL_CATTERMELON("Steal.Cattermelon", Category.STEAL, JukeboxId.CARD_STEAL_CATTERMELON),
    STEAL_POTATO("Steal.Potato", Category.STEAL, JukeboxId.CARD_STEAL_POTATO),
    STEAL_RAINBOW("Steal.Rainbow", Category.STEAL, JukeboxId.CARD_STEAL_RAINBOW),
    STEAL_TACOCAT("Steal.Tacocat", Category.STEAL, JukeboxId.CARD_STEAL_TACOCAT),
    STF_ANGLER5("STF.Angler5", Category.FUTURE5, JukeboxId.CARD_STF_PIG_NEW),
    STF_BEAR5("STF.Bear5", Category.FUTURE5, JukeboxId.CARD_STF_BEAR),
    STF_GOGGLES1("STF.Goggles1", Category.FUTURE1, JukeboxId.CARD_STF_GOGGLES),
    STF_MANTIS3("STF.Mantis3", Category.FUTURE3, JukeboxId.CARD_STF_MANTIS),
    STF_PIGACORN3("STF.Pigacorn3", Category.FUTURE3, JukeboxId.CARD_STF_PIGACORN),
    STREAKING_KITTEN("StreakingKitten", Category.STREAKING_KITTEN, JukeboxId.CARD_STREAKING_KITTENS),
    SUPER_SKIP("SuperSkip", Category.SUPER_SKIP, JukeboxId.CARD_SUPER_SKIP),
    SWAP_TOP_BOTTOM("SwapTopBottom", Category.SWAP_TOP_BOTTOM, JukeboxId.CARD_SWAP_TOP_BOTTOM),
    TAKE_THAT("TakeThat", Category.TAKE_THAT, JukeboxId.CARD_ITT),
    TOWER_OF_POWER("TowerOfPower", Category.TOWER_OF_POWER, JukeboxId.CARD_TOWER_OF_POWER);

    private final String code;
    private final Category category;
    private final JukeboxId jukeboxId;
}