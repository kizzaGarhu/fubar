using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MainMenu {
    public class EventHandler : MonoBehaviour
    {
        //References to Screen objects
        private List<GameObject> _screens;

        //Transition table
        private Dictionary<MenuItemID, ScreenID> _transitions;

        // Use this for initialization
        void Start()
        {
            //Find the references for Screen GameObjects
            FindScreenGameObjects();

            //Create the transition table between menu item id and corresponding screen id (which item points to which screen).
            CreateTransitionTable();

            SetScreenActive(ScreenID.OPENING_SCREEN);
        }

        private void FindScreenGameObjects()
        {
            //Create a new list collection and find and add screen gameobjects to it.
            _screens = new List<GameObject>();
            _screens.Add(GameObject.Find("Opening Screen"));
            _screens.Add(GameObject.Find("New Game Screen"));
            _screens.Add(GameObject.Find("Load Game Screen"));
            _screens.Add(GameObject.Find("Settings Screen"));
            _screens.Add(GameObject.Find("Scores Screen"));
            _screens.Add(GameObject.Find("Credits Screen"));
            _screens.Add(GameObject.Find("Quit Screen"));
        }//FindScreenGameObjects

        private void CreateTransitionTable() 
        {
            _transitions = new Dictionary<MenuItemID, ScreenID>();
            
            //Opening screen transitions
            _transitions.Add(MenuItemID.OPENING_SCREEN_NEW_GAME, ScreenID.NEW_GAME_SCREEN);
            _transitions.Add(MenuItemID.OPENING_SCREEN_LOAD_GAME, ScreenID.LOAD_GAME_SCREEN);
            _transitions.Add(MenuItemID.OPENING_SCREEN_SETTINGS, ScreenID.SETTINGS_SCREEN);
            _transitions.Add(MenuItemID.OPENING_SCREEN_SCORES, ScreenID.SCORES_SCREEN);
            _transitions.Add(MenuItemID.OPENING_SCREEN_CREDITS, ScreenID.CREDITS_SCREEN);
            _transitions.Add(MenuItemID.OPENING_SCREEN_QUIT, ScreenID.QUIT_SCREEN);
            
            //New game screen's transitions
            _transitions.Add(MenuItemID.NEW_GAME_SCREEN_BACK, ScreenID.OPENING_SCREEN);

            //Load game screen's transitions
            _transitions.Add(MenuItemID.LOAD_GAME_SCREEN_BACK, ScreenID.OPENING_SCREEN);

            //Settings screen's transitions
            _transitions.Add(MenuItemID.SETTINGS_SCREEN_BACK, ScreenID.OPENING_SCREEN);

            //Scores screen's transitions
            _transitions.Add(MenuItemID.SCORES_SCREEN_BACK, ScreenID.OPENING_SCREEN);

            //Credits screen's transitions
            _transitions.Add(MenuItemID.CREDITS_SCREEN_BACK, ScreenID.OPENING_SCREEN);

            //Quit screen transitions
            _transitions.Add(MenuItemID.QUIT_SCREEN_CANCEL, ScreenID.OPENING_SCREEN);
        }

        public void HandleLabelButtonEvent(MenuItemID menuItemID) 
        {
            Debug.Log("Event Handler: Handling event " + menuItemID);
            SetScreenActive(_transitions[menuItemID]);
        }

        private void SetScreenActive(ScreenID screenID) 
        {
            //Get corresponding int value from given screenID.
            int _screenID = (int)screenID;
            
            //Loop through menu screens and set screen active if a match is found 
            foreach (int i in Enum.GetValues(typeof(ScreenID)))
            {
                if (i == _screenID)
                    _screens[i].SetActive(true);
                else 
                    _screens[i].SetActive(false);
            }//foreach
        }//SetScreenActive

        public void HandleSliderEvent(MenuItemID menuItemID, float step) 
        { 
        
        }

        public void HandleLaunchEvent(MenuItemID menuItemID) 
        { 
            switch(menuItemID)
            {
                case MenuItemID.NEW_GAME_SCREEN_TUTORIAL:
                    //Launch tutorial scene
                    Debug.Log("Launching tutorial...");
                    break;
                case MenuItemID.NEW_GAME_SCREEN_STORY_MODE:
                    //Start story
                    Debug.Log("Launching story...");
                    break;
                case MenuItemID.NEW_GAME_SCREEN_SURVIVAL:
                    //Start survival
                    Debug.Log("Launching survival...");
                    break;
                case MenuItemID.LOAD_GAME_SCREEN_LOAD:
                    //Load selected game
                    Debug.Log("Launching load...");
                    break;
                case MenuItemID.OPENING_SCREEN_QUICK_MATCH:
                    //Start a random match
                    Debug.Log("Launching quick match...");
                    break;
                case MenuItemID.QUIT_SCREEN_QUIT:
                    //Quit Application
                    Application.Quit();
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }//Update

    }//EventHandler


}//MainMenu
