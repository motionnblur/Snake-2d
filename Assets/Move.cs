using UnityEngine;

public class Move : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.AddListener("LeftArrowPressed", LeftArrowPressed);
        EventManager.AddListener("RightArrowPressed", RightArrowPressed);
        EventManager.AddListener("UpArrowPressed", UpArrowPressed);
        EventManager.AddListener("DownArrowPressed", DownArrowPressed);
    }
    void OnDisable()
    {
        EventManager.RemoveListener("LeftArrowPressed", LeftArrowPressed);
        EventManager.RemoveListener("RightArrowPressed", RightArrowPressed);
        EventManager.RemoveListener("UpArrowPressed", UpArrowPressed);
        EventManager.RemoveListener("DownArrowPressed", DownArrowPressed);
    }

    void LeftArrowPressed()
    {
        Debug.Log("LeftArrowPressed");
    }

    void RightArrowPressed()
    {
        Debug.Log("RightArrowPressed");
    }

    void UpArrowPressed()
    {
        Debug.Log("UpArrowPressed");
    }

    void DownArrowPressed()
    {
        Debug.Log("DownArrowPressed");
    }
}
