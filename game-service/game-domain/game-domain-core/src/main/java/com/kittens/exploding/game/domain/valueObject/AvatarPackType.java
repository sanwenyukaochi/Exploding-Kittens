package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum AvatarPackType {
    BASIC("Basic"),
    ANIMAL("Animal"),
    FOOD("Food"),
    STAFF("Staff"),
    SCIENCE_VS_RELIGION("ScienceVsReligion"),
    FIERCE_PACK("FiercePack"),
    AI_MEDIUM("AIMedium"),
    AI_HARD("AIHard"),
    AI_EASY("AIEasy"),
    SWITCH("Switch");

    private final String value;
}