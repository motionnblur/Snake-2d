using UnityEngine;

public class Collide : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        EventManager.TriggerEvent("OnTriggerEnter", col);
    }
}
