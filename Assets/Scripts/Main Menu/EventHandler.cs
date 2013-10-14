using UnityEngine;
using System.Collections;

namespace MainMenu {
    public class EventHandler : MonoBehaviour
    {
        //References to Screen objects
        private GameObject _openingScreen;
        private GameObject _newGameScreen;
        private GameObject _loadGameScreen;
        private GameObject _settingsScreen;
        private GameObject _quitScreen;

        // Use this for initialization
        void Start()
        {
            FindScreenGameObjects();
        }

        public void HandleEvent(MenuItemID menuItemID) 
        {
            Debug.Log("EventHandler: Handling event " + menuItemID);

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FindScreenGameObjects()
        {
            _openingScreen = GameObject.Find("Opening Screen");
            _newGameScreen = GameObject.Find("New Game Screen");
            _loadGameScreen = GameObject.Find("Load Game Screen");
            _settingsScreen = GameObject.Find("Settings Screen");
            _quitScreen = GameObject.Find("Quit Screen");
        }

    }


}
