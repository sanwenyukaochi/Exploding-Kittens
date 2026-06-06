package com.kittens.exploding.common.base_domain;

@FunctionalInterface
public interface CardEvent {
    void invoke(Card card);
}