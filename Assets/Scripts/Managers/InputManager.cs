using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            EventManager.TriggerEvent("LeftArrowPressed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            EventManager.TriggerEvent("RightArrowPressed");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            EventManager.TriggerEvent("UpArrowPressed");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            EventManager.TriggerEvent("DownArrowPressed");
        }
    }
}
