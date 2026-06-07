package com.exploding_kittens.screen;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.ScreenAdapter;
import com.badlogic.gdx.graphics.Color;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.scenes.scene2d.Stage;
import com.badlogic.gdx.utils.viewport.FitViewport;
import com.exploding_kittens.ExplodingKittens;
import com.exploding_kittens.bootstrap.GameContext;

public abstract class BaseScreen extends ScreenAdapter {
    protected final ExplodingKittens game;
    protected final GameContext context;
    protected final Stage stage;
    private final Color clearColor;

    protected BaseScreen(ExplodingKittens game, GameContext context) {
        this(game, context, new Color(0.09f, 0.1f, 0.13f, 1f));
    }

    protected BaseScreen(ExplodingKittens game, GameContext context, Color clearColor) {
        this.game = game;
        this.context = context;
        this.clearColor = new Color(clearColor);
        this.stage = new Stage(new FitViewport(GameContext.WORLD_WIDTH, GameContext.WORLD_HEIGHT));
    }

    @Override
    public void show() {
        Gdx.input.setInputProcessor(stage);
    }

    @Override
    public void render(float delta) {
        Gdx.gl.glClearColor(clearColor.r, clearColor.g, clearColor.b, clearColor.a);
        Gdx.gl.glClear(GL20.GL_COLOR_BUFFER_BIT);
        stage.act(Math.min(delta, 1f / 30f));
        stage.draw();
    }

    @Override
    public void resize(int width, int height) {
        if (width <= 0 || height <= 0) {
            return;
        }
        stage.getViewport().update(width, height, true);
    }

    @Override
    public void hide() {
        if (Gdx.input.getInputProcessor() == stage) {
            Gdx.input.setInputProcessor(null);
        }
    }

    @Override
    public void dispose() {
        stage.dispose();
    }
}
