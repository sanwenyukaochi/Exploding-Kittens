Feature: 玩家互动牌

  Scenario: 人情牌让对方选择给牌
    Given 当前轮到玩家A的回合
    And 玩家A手中有 "人情" 牌
    And 玩家B手中有牌
    When 玩家A指定玩家B打出 "人情" 牌
    Then 玩家B必须选择手中的 1 张牌交给玩家A
    And 玩家B选择给哪张牌
    And 玩家A获得该牌

  Scenario: 两张相同牌随机抽取
    Given 玩家A手中有两张相同的 "跳过" 牌
    And 玩家B手中有至少1张牌
    When 玩家A打出这两张 "跳过" 牌的组合
    Then 玩家A从玩家B手中随机抽取 1 张牌
    And 玩家A获得该牌

  Scenario: 三张相同牌指定索要
    Given 玩家A手中有三张相同的 "攻击" 牌
    And 玩家B手中有 "拆弹" 牌
    When 玩家A打出这三张 "攻击" 牌的组合
    And 玩家A指定索要 "拆弹" 牌
    Then 玩家B必须将 "拆弹" 牌交给玩家A
    And 如果玩家B没有指定牌，则无效果

  Scenario: 五张不同牌从弃牌堆回收
    Given 玩家A手中有5张不同的功能牌
    And 弃牌堆中有 "拆弹" 牌
    When 玩家A打出这5张不同的牌
    Then 玩家A可以从弃牌堆中拿回任意 1 张牌