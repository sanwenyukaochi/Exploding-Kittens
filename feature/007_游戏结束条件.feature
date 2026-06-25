Feature: 游戏结束条件

  Scenario: 只剩一名玩家存活
    Given 游戏进行中
    And 已有 3 名玩家因抽到爆炸猫出局
    And 原本有 4 名玩家
    When 第3名玩家被淘汰
    Then 场上只剩最后 1 名玩家
    And 游戏立即结束
    And 该玩家被宣告为赢家

  Scenario: 牌堆抽完但仍有多个玩家存活（理论上）
    Given 牌堆已抽完
    And 仍有至少 2 名玩家存活（这种情况在标准规则下极罕见）
    When 牌堆耗尽
    Then 游戏应以平局结束或重新洗弃牌堆继续