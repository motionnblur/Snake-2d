using System.Collections.Generic;
using UnityEngine;
public enum Direction
{
    Left,
    Right,
    Up,
    Down
}
public class Move : MonoBehaviour
{
    public List<GameObject> tails = new List<GameObject>();
    Direction currentDirection;

    void Awake()
    {
        currentDirection = GetRandomDirection();
    }

    void Start()
    {
        InvokeRepeating("MoveSnake", 0f, 0.5f);
    }

    void OnEnable()
    {
        EventManager.AddListener("LeftArrowPressed", LeftArrowPressed);
        EventManager.AddListener("RightArrowPressed", RightArrowPressed);
        EventManager.AddListener("UpArrowPressed", UpArrowPressed);
        EventManager.AddListener("DownArrowPressed", DownArrowPressed);
        EventManager.AddListener("OnGameEnd", OnGameEnd);
    }
    void OnDisable()
    {
        EventManager.RemoveListener("LeftArrowPressed", LeftArrowPressed);
        EventManager.RemoveListener("RightArrowPressed", RightArrowPressed);
        EventManager.RemoveListener("UpArrowPressed", UpArrowPressed);
        EventManager.RemoveListener("DownArrowPressed", DownArrowPressed);
        EventManager.RemoveListener("OnGameEnd", OnGameEnd);
    }

    void MoveSnake()
    {
        UpdateTails(transform.position);

        if (currentDirection == Direction.Left)
        {
            transform.position += new Vector3(-0.4f, 0, 0);
            if (Mathf.Abs(transform.position.x) > 8.2f)
            {
                EventManager.TriggerEvent("OnGameEnd");
            }
        }
        else if (currentDirection == Direction.Right)
        {
            transform.position += new Vector3(0.4f, 0, 0);
            if (Mathf.Abs(transform.position.x) > 8.2f)
            {
                EventManager.TriggerEvent("OnGameEnd");
            }
        }
        else if (currentDirection == Direction.Up)
        {
            transform.position += new Vector3(0, 0.4f, 0);
            if (Mathf.Abs(transform.position.y) > 4.2f)
            {
                EventManager.TriggerEvent("OnGameEnd");
            }
        }
        else if (currentDirection == Direction.Down)
        {
            transform.position += new Vector3(0, -0.4f, 0);
            if (Mathf.Abs(transform.position.y) > 4.2f)
            {
                EventManager.TriggerEvent("OnGameEnd");
            }
        }
    }

    void LeftArrowPressed()
    {
        currentDirection = Direction.Left;
    }

    void RightArrowPressed()
    {
        currentDirection = Direction.Right;
    }

    void UpArrowPressed()
    {
        currentDirection = Direction.Up;
    }

    void DownArrowPressed()
    {
        currentDirection = Direction.Down;
    }

    Direction GetRandomDirection()
    {
        return (Direction)Random.Range(0, System.Enum.GetValues(typeof(Direction)).Length);
    }

    void UpdateTails(Vector3 pos)
    {
        for (int i = tails.Count - 1; i >= 0; i--)
        {
            tails[i].transform.position = i == 0 ? pos : tails[i - 1].transform.position;
        }
    }
    void OnGameEnd()
    {
        CancelInvoke("MoveSnake");
    }
}
