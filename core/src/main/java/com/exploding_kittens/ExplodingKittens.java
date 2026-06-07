package com.exploding_kittens;

import com.badlogic.gdx.Game;
import com.exploding_kittens.bootstrap.GameContext;
import com.exploding_kittens.screen.BootScreen;
import com.exploding_kittens.screen.MainMenuScreen;
import com.exploding_kittens.screen.PlaceholderScreen;

public class ExplodingKittens extends Game {
    private final GameContext context = new GameContext();

    @Override
    public void create() {
        this.setScreen(new BootScreen(this, context));
    }

    public void showMainMenu() {
        this.setScreen(new MainMenuScreen(this, context));
    }

    public void showPlaceholder(String title, String message) {
        this.setScreen(new PlaceholderScreen(this, context, title, message));
    }

    @Override
    public void dispose() {
        super.dispose();
        context.dispose();
    }
}
