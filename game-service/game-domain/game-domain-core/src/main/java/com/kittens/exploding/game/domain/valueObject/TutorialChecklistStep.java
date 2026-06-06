package com.kittens.exploding.game.domain.valueObject;

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