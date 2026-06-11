package io.kittens.exploding.card.domain.valueObject;

import io.kittens.exploding.common.domain.valueObject.BaseId;

public class CardId extends BaseId<Long> {
    protected CardId(Long value) {
        super(value);
    }
}
