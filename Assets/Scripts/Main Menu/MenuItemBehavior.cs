using UnityEngine;
using System.Collections;

namespace MainMenu
{
    class MenuItemBehavior : MonoBehaviour
    {
        //Class Variables
        public GameObject eventHandler; //Reference to the EventHandler GameObject
        public MenuItemID menuItemID;

        void OnMouseDown() {
            Debug.Log("MenuItemBehaviour: Clicked " + menuItemID);
            eventHandler.GetComponent<EventHandler>().HandleEvent(menuItemID);
        }
    
    }
}
