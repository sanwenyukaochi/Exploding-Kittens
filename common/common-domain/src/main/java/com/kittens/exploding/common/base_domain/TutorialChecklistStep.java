package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum TutorialChecklistStep {
    INTRO("Intro"),
    TAP("Tap"),
    PLAY("Play"),
    DRAW("Draw"),
    FINISH("Finish");

    private final String value;
}