package com.exploding_kittens.screen;

import com.exploding_kittens.ExplodingKittens;
import com.exploding_kittens.bootstrap.GameContext;

public class BootScreen extends BaseScreen {
    public BootScreen(ExplodingKittens game, GameContext context) {
        super(game, context);
    }

    @Override
    public void show() {
        super.show();
        context.initialize();
        game.showMainMenu();
    }
}
