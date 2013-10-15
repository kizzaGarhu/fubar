using UnityEngine;
using System.Collections;


namespace MainMenu {
    public enum MenuItemID
    {
        //Opening screen's menu items
        OPENING_SCREEN_NEW_GAME,
        OPENING_SCREEN_LOAD_GAME,
        OPENING_SCREEN_QUICK_MATCH,
        OPENING_SCREEN_SETTINGS,
        OPENING_SCREEN_SCORES,
        OPENING_SCREEN_CREDITS,
        OPENING_SCREEN_QUIT,
        
        //New game screen's menu items
        NEW_GAME_SCREEN_DOGS_OPTION,
        NEW_GAME_SCREEN_CATS_OPTION,
        NEW_GAME_SCREEN_TUTORIAL,
        NEW_GAME_SCREEN_STORY_MODE,
        NEW_GAME_SCREEN_SURVIVAL,
        NEW_GAME_SCREEN_BACK,

        //Load game screen's menu items
        LOAD_GAME_SCREEN_LOAD,
        LOAD_GAME_SCREEN_BACK,

        //Settings screen's menu items
        SETTINGS_SCREEN_DIFFICULTY_SLIDER,
        SETTINGS_SCREEN_MUSIC_SLIDER,
        SETTINGS_SCREEN_EFFECTS_SLIDER,
        SETTINGS_SCREEN_DEFAULT_SETTINGS,
        SETTINGS_SCREEN_BACK,

        //Scores screen's menu items
        SCORES_SCREEN_BACK,

        //Credits screen's menu items
        CREDITS_SCREEN_BACK,

        //Quit screen's menu items
        QUIT_SCREEN_QUIT,
        QUIT_SCREEN_CANCEL

    }

}

