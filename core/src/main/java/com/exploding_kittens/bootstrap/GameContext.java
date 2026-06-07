package com.exploding_kittens.bootstrap;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.files.FileHandle;
import com.badlogic.gdx.scenes.scene2d.ui.Skin;
import com.badlogic.gdx.utils.Disposable;

public class GameContext implements Disposable {
    public static final float WORLD_WIDTH = 1920f;
    public static final float WORLD_HEIGHT = 1080f;

    private Skin skin;

    public void initialize() {
        if (skin == null) {
            FileHandle skinFile = Gdx.files.internal("ui/uiskin.json");
            skin = new Skin(skinFile);
        }
    }

    public Skin getSkin() {
        if (skin == null) {
            throw new IllegalStateException("GameContext is not initialized.");
        }
        return skin;
    }

    @Override
    public void dispose() {
        if (skin != null) {
            skin.dispose();
            skin = null;
        }
    }
}
