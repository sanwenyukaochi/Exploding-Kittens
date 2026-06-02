package com.kittens.exploding.game.domain.deck;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DeckType {
    CORE("核心包", "基础游戏卡牌"),
    PARTY("派对包", "适合多人游戏的卡牌"),
    BETRAYAL("背叛包", "包含背叛/内鬼机制的卡牌"),
    STREAKING("裸奔包", "裸奔猫相关卡牌扩展"),
    BARKING_KITTENS("吠叫猫包", "吠叫猫扩展包"),
    MIXED("混合包", "多个扩展包混搭的牌堆");

    private final String name;
    private final String description;
}
