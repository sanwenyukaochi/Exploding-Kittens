package com.exploding_kittens.screen;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.scenes.scene2d.ui.Image;
import com.badlogic.gdx.scenes.scene2d.ui.Label;
import com.badlogic.gdx.scenes.scene2d.ui.Table;
import com.badlogic.gdx.scenes.scene2d.ui.TextButton;
import com.badlogic.gdx.utils.Scaling;
import com.exploding_kittens.ExplodingKittens;
import com.exploding_kittens.bootstrap.GameContext;

public class MainMenuScreen extends BaseScreen {

    private Texture backgroundTexture;

    public MainMenuScreen(ExplodingKittens game, GameContext context) {
        super(game, context);
        addBackground();
        addTitle();
        addAvatarPanel();
        addMainButtons();
        addBottomButtons();
    }

    private void addBackground() {
        backgroundTexture = new Texture(Gdx.files.internal("backgrounds/Background.Wood.Win.png"));
        Image background = new Image(backgroundTexture);
        background.setFillParent(true);
        background.setScaling(Scaling.fill);
        stage.addActor(background);
    }

    private void addTitle() {
        Label title = new Label("EXPLODING KITTENS", context.getSkin(), "default");
        title.setFontScale(2.2f);
        title.setPosition(500f, 770f);
        title.setSize(700f, 80f);
        stage.addActor(title);
    }

    private void addAvatarPanel() {
        Table avatarPanel = new Table();
        avatarPanel.defaults().pad(8f);
        Label header = new Label("YOUR AVATAR", context.getSkin(), "default");
        Label name = new Label("JELLY BEAN", context.getSkin(), "default");
        Label avatar = new Label("[ AVATAR IMAGE ]", context.getSkin(), "default");
        TextButton changeButton = new TextButton("CHANGE AVATAR", context.getSkin());
        avatarPanel.add(header).row();
        avatarPanel.add(name).padTop(20f).row();
        avatarPanel.add(avatar).height(260f).padTop(30f).row();
        avatarPanel.add(changeButton).width(300f).height(70f).padTop(30f).row();
        avatarPanel.setPosition(120f, 160f);
        avatarPanel.setSize(460f, 560f);
        stage.addActor(avatarPanel);
    }

    private void addMainButtons() {
        TextButton friendsButton = new TextButton("PLAY WITH FRIENDS\nHOST OR JOIN A PRIVATE GAME", context.getSkin());
        friendsButton.getLabel().setFontScale(1.1f);
        friendsButton.getLabel().setWrap(true);
        friendsButton.addListener(event -> {
            if (!friendsButton.isPressed()) return false;
            game.showPlaceholder("Play With Friends", "Private game will be here.");
            return true;
        });
        friendsButton.setPosition(740f, 610f);
        friendsButton.setSize(650f, 110f);
        stage.addActor(friendsButton);

        TextButton strangersButton = new TextButton("PLAY WITH STRANGERS\nFIND A PUBLIC GAME", context.getSkin());
        strangersButton.getLabel().setFontScale(1.1f);
        strangersButton.getLabel().setWrap(true);
        strangersButton.addListener(event -> {
            if (!strangersButton.isPressed()) return false;
            game.showPlaceholder("Play With Strangers", "Public matchmaking will be here.");
            return true;
        });
        strangersButton.setPosition(780f, 470f);
        strangersButton.setSize(650f, 110f);
        stage.addActor(strangersButton);

        TextButton singleButton = new TextButton("PLAY WITH YOURSELF\nPLAY A SINGLE PLAYER MATCH", context.getSkin());
        singleButton.getLabel().setFontScale(1.1f);
        singleButton.getLabel().setWrap(true);
        singleButton.addListener(event -> {
            if (!singleButton.isPressed()) return false;
            game.showPlaceholder("Single Player", "Single player match will be here.");
            return true;
        });
        singleButton.setPosition(740f, 330f);
        singleButton.setSize(650f, 110f);
        stage.addActor(singleButton);
    }

    private void addBottomButtons() {
        TextButton tutorialButton = new TextButton("TUTORIAL\nLEARN THE ROPES", context.getSkin());
        tutorialButton.getLabel().setFontScale(1.1f);
        tutorialButton.getLabel().setWrap(true);
        tutorialButton.addListener(event -> {
            if (!tutorialButton.isPressed()) return false;
            game.showPlaceholder("Tutorial", "Tutorial will be here.");
            return true;
        });
        tutorialButton.setPosition(740f, 160f);
        tutorialButton.setSize(400f, 100f);
        stage.addActor(tutorialButton);

        TextButton settingsButton = new TextButton("SETTINGS\nAND MORE", context.getSkin());
        settingsButton.getLabel().setFontScale(1.1f);
        settingsButton.getLabel().setWrap(true);
        settingsButton.addListener(event -> {
            if (!settingsButton.isPressed()) return false;
            game.showPlaceholder("Settings", "Settings will be here.");
            return true;
        });
        settingsButton.setPosition(1180f, 160f);
        settingsButton.setSize(300f, 100f);
        stage.addActor(settingsButton);
    }


    @Override
    public void dispose() {
        backgroundTexture.dispose();
        super.dispose();
    }
}
