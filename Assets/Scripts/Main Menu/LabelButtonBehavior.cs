using UnityEngine;
using System.Collections;

namespace MainMenu
{
    class LabelButtonBehavior : MonoBehaviour
    {
        //Class Variables
        public GameObject eventHandler; //Reference to the EventHandler GameObject
        public MenuItemID menuItemID;

        void OnMouseDown() {
            Debug.Log("MenuItemBehaviour: Clicked " + menuItemID);
            eventHandler.GetComponent<EventHandler>().HandleLabelButtonEvent(menuItemID);
        }
    
    }
}
