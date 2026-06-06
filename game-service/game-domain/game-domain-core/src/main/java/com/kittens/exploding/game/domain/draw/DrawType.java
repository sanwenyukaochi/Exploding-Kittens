package com.kittens.exploding.game.domain.draw;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DrawType {
    UNDRAWN("卡牌尚未被抽取"),
    DRAWN("卡牌已被抽取"),
    STEAL("通过偷窃获得的卡牌"),
    INITIAL_HAND("游戏开始时发放的初始手牌");

    private final String description;
}