using UnityEngine;
using System.Collections;


namespace MainMenu
{
    [RequireComponent(typeof(BoxCollider))]
    class SliderBehaviour : MonoBehaviour
    {
        //Class variables
        //References
        public MenuItemID menuItemID; //The id of the menu item
        public GameObject eventHandler; //Reference to the event handler

        //Slider attributes
        public float minValue = 0.0f;
        public float maxValue = 20.0f;
        public float step = 1.0f;
        public float sliderValue = 10.0f;

        // Slider's control variables
        private float _beforeDrag;
        private float _dragDelta;
        private float _dragSensitivity = 2.0f;
        private float _physicalStep = 5.0f;

        void Start() 
        { 
        
        }

        void OnMouseDown()
        {
            _beforeDrag = Input.mousePosition.x;

        }

        void OnMouseDrag()
        {
            //Drag delta = position before dragging - mouse's current x position. 
            _dragDelta = _beforeDrag - Input.mousePosition.x;
            
            //Move slider to the left if dragging delta was greater than drag sensitivity.
            if (_dragDelta >= _dragSensitivity) 
            {
                //Check whether slider has reached minimum value.
                if (sliderValue > minValue)
                {
                    gameObject.transform.position -= new Vector3(_physicalStep, 0, 0);
                    sliderValue -= step;
                    _beforeDrag = Input.mousePosition.x;
                    Debug.Log("1 step, value is now: " + sliderValue);
                }
                return;
            }

            //Move slider to the right if dragging delta was less than drag sensitivity.
            if (_dragDelta <= -(_dragSensitivity)) 
            {
                if (sliderValue < maxValue)
                {
                    gameObject.transform.position += new Vector3(_physicalStep, 0, 0);
                    sliderValue += step;
                    _beforeDrag = Input.mousePosition.x;
                    Debug.Log("1 step, value is now: " + sliderValue);
                }
                return;
            }
                    
        }

        void OnMouseUp() 
        { 
            //TODO:
            //Create event handler for music and sound effects.
        }

    
    }
}
