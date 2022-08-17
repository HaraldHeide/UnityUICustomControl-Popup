using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace PopupTest
{
    public class Popup_Setup : MonoBehaviour
    {
        private void OnEnable()
        {
            UIDocument ui = GetComponent<UIDocument>();
            VisualElement root = ui.rootVisualElement;

            PopupWindow popup = new PopupWindow();
            root.Add(popup);

            popup.confirmed += () => Debug.Log("Confirmed button was pressed");
            popup.canceled += () => Debug.Log("Cancel button was pressed");
            popup.canceled += () => root.Remove(popup);
        }
    }
}