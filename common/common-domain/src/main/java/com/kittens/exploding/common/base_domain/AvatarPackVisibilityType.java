package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum AvatarPackVisibilityType {
    PUBLIC("Public"),
    WIZARD_ONLY("WizardOnly"),
    VISIBLE_AFTER_CODE_REDEEM("VisibleAfterCodeRedeem"),
    VISIBLE_AFTER_MEDIUM_UNLOCK("VisibleAfterMediumUnlock"),
    VISIBLE_AFTER_HARD_UNLOCK("VisibleAfterHardUnlock"),
    VISIBLE_AFTER_EASY_UNLOCK("VisibleAfterEasyUnlock"),
    HIDDEN("Hidden");

    private final String value;
}