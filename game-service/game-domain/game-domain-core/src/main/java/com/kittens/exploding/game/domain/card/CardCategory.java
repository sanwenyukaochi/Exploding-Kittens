package com.kittens.exploding.game.domain.card;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CardCategory {
    DEFUSE("拆除牌", "拆除炸弹，避免爆炸"),
    BOMB("炸弹牌", "抽到即爆炸，除非用拆除牌"),
    SKIP("跳过牌", "跳过自己的回合"),
    DIARRHEA_2("腹泻猫2", "与腹泻猫1组合使用，让对手抽多张牌"),
    FUTURE_3("预见未来3", "查看牌堆顶3张牌"),
    SHUFFLE("洗牌", "重新洗匀牌堆"),
    STEAL("偷窃", "从对手手牌中偷一张牌"),
    FUTURE_1("预见未来1", "查看牌堆顶1张牌"),
    DRAW_FROM_BOTTOM("从底部抽牌", "从牌堆底抽牌而非顶部"),
    REVERSE("反转", "反转出牌顺序方向"),
    CHICKEN_PARTY("鸡派对", "召唤所有鸡牌"),
    DIARRHEA_1("腹泻猫1", "与腹泻猫2组合使用，让对手抽多张牌"),
    SLAP_1("耳光1", "攻击效果"),
    SLAP_2("耳光2", "攻击效果"),
    SLAP_3("耳光3", "攻击效果"),
    ATTACK_CAT_BUTT("攻击猫屁股", "结束自己回合，让下家连续进行2个回合"),
    FUTURE_5("预见未来5", "查看牌堆顶5张牌"),
    ALTER_2("调整2", "交换/调整2张牌的位置"),
    ALTER_3("调整3", "交换/调整3张牌的位置"),
    ALTER_5("调整5", "交换/调整5张牌的位置"),
    FAKE_SHUFFLE("假洗牌", "假装洗牌，其实不改变顺序"),
    KITTEN_ROLL_CALL("猫点名", "所有玩家亮出某种猫牌"),
    NONE("无", "空卡牌"),
    SELF_SLAP_2("自打2", "对自己造成2次惩罚"),
    SELF_SLAP_3("自打3", "对自己造成3次惩罚"),
    STREAKING_KITTEN("裸奔猫", "特殊的猫牌效果"),
    SUPER_SKIP("超级跳过", "跳过自己的回合且不能被连锁"),
    SWAP_TOP_BOTTOM("交换顶部底部", "将牌堆顶和底部的牌交换"),
    CATOMIC_BOMB("猫原子弹", "对全体玩家造成爆炸效果"),
    GARBAGE_COLLECTION("垃圾收集", "回收弃牌堆的牌"),
    MARK("标记", "标记某张牌"),
    BARKING_KITTEN("吠叫猫", "触发特殊效果"),
    TAKE_THAT("接招吧", "指向性攻击卡牌"),
    BURY("埋葬", "将牌埋入牌堆深处"),
    POT_LUCK("随机抽奖", "从公共牌堆随机抽牌"),
    TOWER_OF_POWER("力量之塔", "多张牌组合的强力效果"),
    SHARE_THE_FUTURE("共享未来", "让所有玩家都看未来的牌"),
    ;

    private final String name;
    private final String description;
}
