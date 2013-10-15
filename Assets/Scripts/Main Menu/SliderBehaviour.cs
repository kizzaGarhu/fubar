using UnityEngine;
using System.Collections;


namespace MainMenu
{
    [RequireComponent(typeof(BoxCollider))]
    class SliderBehaviour : MonoBehaviour
    {
        //Class variables
        public MenuItemID menuItemID;
        
        public float minValue = 0.0f;
        public float maxValue = 20.0f;
        public float step = 1.0f;
        private float _sliderValue = 10.0f;

        void Start() 
        { 
        
        }

        // Slider's control variables
        private float _beforeDrag;
        private float _dragDelta;
        private float _dragSensitivity = 2.0f;

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
                if (_sliderValue > minValue)
                {
                    gameObject.transform.position -= new Vector3(5.0f, 0, 0);
                    _sliderValue -= step;
                    _beforeDrag = Input.mousePosition.x;
                    Debug.Log("1 step, value is now: " + _sliderValue);
                }
                return;
            }

            //Move slider to the right if dragging delta was less than drag sensitivity.
            if (_dragDelta <= -(_dragSensitivity)) 
            {
                if (_sliderValue < maxValue)
                {
                    gameObject.transform.position += new Vector3(5.0f, 0, 0);
                    _sliderValue += step;
                    _beforeDrag = Input.mousePosition.x;
                    Debug.Log("1 step, value is now: " + _sliderValue);
                }
                return;
            }
                    
        }

    
    }
}
