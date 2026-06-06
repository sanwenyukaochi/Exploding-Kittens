package com.kittens.exploding.common.base_domain;

import lombok.Getter;
import lombok.RequiredArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@RequiredArgsConstructor
public class Card {
    private final String id;
    // private final Texture texture;
    private final CardCategory category;
    private final String personalityCaption;
    private final String jukeboxId;

    private boolean isDiarrhead;
    private boolean isDisguisedAsCatButt;
    private boolean isMarked;
    private DrawType drawType;
    // private Player placingPlayer;

    private CardEvent onSprayedWithDiarrhea;
    private CardEvent onDiarrheaWiped;
    private CardEvent onDisguised;
    private CardEvent onSheddedDisguise;
    private CardEvent onMarked;
    private CardEvent onUnMarked;

    public boolean hasPlacingPlayer() {
        return false;
    }

    public boolean hasJukeboxSound() {
        return false;
    }

    public boolean hasDiscardCardSubstituteCategory() {
        return false;
    }

    public CardCategory discardCardSubstituteCategory() {
        return null;
    }

    public boolean restartsTurnTimerWhenPlayed() {
        return false;
    }

    // public CategoryMetadata categoryMetadata() {
    //     return null;
    // }

    public boolean isValidInStartingHand() {
        return false;
    }

    public boolean isExplodingKitten() {
        return false;
    }

    public boolean isDefuse() {
        return false;
    }

    public boolean isSelfSlap() {
        return false;
    }

    public void reset() {}
    public void markCard() {}
    public void unMarkCard() {}
    public void sprayWithDiarrhea() {}
    public void wipeUpDiarrhea() {}
    public void disguise() {}
    public void shedDisguise() {}
}