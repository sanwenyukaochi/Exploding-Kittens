package com.exploding_kittens.screen;

import com.badlogic.gdx.scenes.scene2d.ui.Label;
import com.badlogic.gdx.scenes.scene2d.ui.Table;
import com.badlogic.gdx.scenes.scene2d.ui.TextButton;
import com.exploding_kittens.ExplodingKittens;
import com.exploding_kittens.bootstrap.GameContext;

public class PlaceholderScreen extends BaseScreen {
    public PlaceholderScreen(ExplodingKittens game, GameContext context, String title, String message) {
        super(game, context);
        buildUi(title, message);
    }

    private void buildUi(String titleText, String messageText) {
        Table root = new Table();
        root.setFillParent(true);
        root.defaults().pad(10f);

        Label title = new Label(titleText, context.getSkin());
        Label message = new Label(messageText, context.getSkin());
        message.setWrap(true);

        TextButton backButton = new TextButton("Back", context.getSkin());
        backButton.addListener(event -> {
            if (!backButton.isPressed()) {
                return false;
            }
            game.showMainMenu();
            return true;
        });

        root.add(title).row();
        root.add(message).width(520f).row();
        root.add(backButton).width(200f).padTop(20f).row();

        stage.addActor(root);
    }
}
