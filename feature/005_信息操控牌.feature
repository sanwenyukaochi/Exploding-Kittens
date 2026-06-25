Feature: 信息操控牌

  Scenario: 预见未来查看牌堆顶3张
    Given 当前轮到玩家A的回合
    And 玩家A手中有 "预见未来" 牌
    When 玩家A打出 "预见未来" 牌
    Then 玩家A可以查看牌堆顶部的 3 张牌
    And 查看后必须按原顺序放回
    And 其他玩家不能看到这些牌
    And 玩家A的回合继续（可以选择出其他牌或抽牌）

  Scenario: 洗牌打乱牌堆
    Given 当前轮到玩家A的回合
    And 玩家A手中有 "洗牌" 牌
    When 玩家A打出 "洗牌" 牌
    Then 整个牌堆被随机重新洗混
    And 玩家A的回合继续

  Scenario: 组合使用预见未来和洗牌
    Given 玩家A打出 "预见未来" 看到牌堆顶是 "爆炸猫"
    When 玩家A打出 "洗牌" 牌
    Then 牌堆被重新洗混
    And "爆炸猫" 不再位于牌堆顶部
    And 玩家A可以安全抽牌
