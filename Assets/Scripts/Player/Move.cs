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
        if (Mathf.Abs(transform.position.x) > 8f)
        {
            Debug.Log("end");
        }
    }

    void RightArrowPressed()
    {
        transform.position += new Vector3(1, 0, 0);
        if (Mathf.Abs(transform.position.x) > 8f)
        {
            Debug.Log("end");
        }
    }

    void UpArrowPressed()
    {
        transform.position += new Vector3(0, 1, 0);
        if (Mathf.Abs(transform.position.y) > 4f)
        {
            Debug.Log("end");
        }
    }

    void DownArrowPressed()
    {
        transform.position += new Vector3(0, -1, 0);
        if (Mathf.Abs(transform.position.y) > 4f)
        {
            Debug.Log("end");
        }
    }
}
