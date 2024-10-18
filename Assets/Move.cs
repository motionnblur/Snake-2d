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
        transform.position += new Vector3(-1, 0, 0);
    }

    void RightArrowPressed()
    {
        transform.position += new Vector3(1, 0, 0);
    }

    void UpArrowPressed()
    {
        transform.position += new Vector3(0, 1, 0);
    }

    void DownArrowPressed()
    {
        transform.position += new Vector3(0, -1, 0);
    }
}
