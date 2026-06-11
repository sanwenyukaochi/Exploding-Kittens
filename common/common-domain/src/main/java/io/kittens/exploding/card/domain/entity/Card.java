package io.kittens.exploding.card.domain.entity;

import io.kittens.exploding.card.domain.valueObject.CardCategory;
import io.kittens.exploding.card.domain.valueObject.CardId;
import io.kittens.exploding.common.domain.entity.AggregateRoot;
import io.kittens.exploding.common.domain.valueObject.DrawType;
import io.kittens.exploding.player.domain.entity.Player;

public class Card extends AggregateRoot<CardId> {
    public CardCategory Category;
    public boolean IsDiarrheaD;
    public boolean IsDisguisedAsCatButt;
    public boolean IsMarked;
    public DrawType DrawType;
    public Player PlacingPlayer;
}