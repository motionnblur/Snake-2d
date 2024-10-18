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
    }
    void OnDisable()
    {
        EventManager.RemoveListener("LeftArrowPressed", LeftArrowPressed);
        EventManager.RemoveListener("RightArrowPressed", RightArrowPressed);
        EventManager.RemoveListener("UpArrowPressed", UpArrowPressed);
        EventManager.RemoveListener("DownArrowPressed", DownArrowPressed);
    }

    void MoveSnake()
    {
        if (currentDirection == Direction.Left)
        {
            transform.position += new Vector3(-0.4f, 0, 0);
            if (Mathf.Abs(transform.position.x) > 8.2f)
            {
                Debug.Log("end");
            }
        }
        else if (currentDirection == Direction.Right)
        {
            transform.position += new Vector3(0.4f, 0, 0);
            if (Mathf.Abs(transform.position.x) > 8.2f)
            {
                Debug.Log("end");
            }
        }
        else if (currentDirection == Direction.Up)
        {
            transform.position += new Vector3(0, 0.4f, 0);
            if (Mathf.Abs(transform.position.y) > 4.2f)
            {
                Debug.Log("end");
            }
        }
        else if (currentDirection == Direction.Down)
        {
            transform.position += new Vector3(0, -0.4f, 0);
            if (Mathf.Abs(transform.position.y) > 4.2f)
            {
                Debug.Log("end");
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
}
