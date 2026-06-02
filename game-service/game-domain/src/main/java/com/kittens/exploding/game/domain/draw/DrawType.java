package com.kittens.exploding.game.domain.draw;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DrawType {
    UNDRAWN("未抽取", "卡牌尚未被抽取"),
    DRAWN("已抽取", "卡牌已被抽取"),
    STEAL("偷窃", "通过偷窃获得的卡牌"),
    INITIAL_HAND("初始手牌", "游戏开始时发放的初始手牌");

    private final String name;
    private final String description;
}
