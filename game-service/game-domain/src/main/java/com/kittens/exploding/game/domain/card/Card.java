package com.kittens.exploding.game.domain.card;

import com.kittens.exploding.common.domain.entity.AggregateRoot;
import com.kittens.exploding.game.domain.draw.DrawType;
import com.kittens.exploding.game.domain.valueObject.CardId;
import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public final class Card extends AggregateRoot<CardId> {
    // public final Texture Texture;
    private final CardCategory category;
    private final String personalityCaption;
    private final String jukeboxId;

    // public boolean IsDiarrhead;
    // public bool IsDisguisedAsCatButt;
    // public bool IsMarked;
    public final DrawType DrawType;
    // public Player PlacingPlayer;
    // public CardEvent OnSprayedWithDiarrhea;
    // public CardEvent OnDiarrheaWiped;
    // public CardEvent OnDisguised;
    // public CardEvent OnSheddedDisguise;
    // public CardEvent OnMarked;
    // public CardEvent OnUnMarked;

    // public boolean isBomb() {
    //    return category == CardCategory.BOMB;
    // }
    //
    // public boolean isDefuse() {
    //    return category == CardCategory.DEFUSE;
    // }
    //
    // public boolean isValidInStartingHand() {
    //    return category.ordinal() > CardCategory.BOMB.ordinal();
    // }
}
