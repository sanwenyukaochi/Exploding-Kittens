package io.kittens.exploding.player.domain.valueObject;

import io.kittens.exploding.common.domain.valueObject.BaseId;

public class PlayerId extends BaseId<Long> {
    protected PlayerId(Long value) {
        super(value);
    }
}
