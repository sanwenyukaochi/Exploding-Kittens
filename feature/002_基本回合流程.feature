Feature: 基本回合流程

  Scenario: 玩家选择跳过回合
    Given 当前轮到玩家A的回合
    And 玩家A手中有 "跳过" 牌
    When 玩家A打出 "跳过" 牌
    Then 玩家A的回合立即结束
    And 玩家A不需要抽牌
    And 下一个玩家（玩家B）的回合开始

  Scenario: 玩家不出牌直接抽牌
    Given 当前轮到玩家A的回合
    When 玩家A选择不出任何牌
    And 玩家A从牌堆顶抽1张牌
    Then 玩家A的手牌数增加1
    And 玩家A的回合结束

  Scenario: 玩家出多张牌后再抽牌
    Given 当前轮到玩家A的回合
    And 玩家A手中有 "预见未来" 牌和 "洗牌" 牌
    When 玩家A打出 "预见未来" 牌
    And 玩家A打出 "洗牌" 牌
    And 玩家A从牌堆顶抽1张牌
    Then 所有牌的效果应依次生效
    And 玩家A最终手牌数 = 原手牌数 - 2 + 1
