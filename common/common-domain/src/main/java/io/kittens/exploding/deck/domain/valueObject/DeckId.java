package io.kittens.exploding.deck.domain.valueObject;

import io.kittens.exploding.common.domain.valueObject.BaseId;

public class DeckId extends BaseId<Long> {
    protected DeckId(Long value) {
        super(value);
    }
}
