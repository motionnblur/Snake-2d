using UnityEngine;

public class Pick : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.AddListener<Collider2D>("OnTriggerEnter", TriggerEnter);
    }
    void OnDisable()
    {
        EventManager.RemoveListener<Collider2D>("OnTriggerEnter", TriggerEnter);
    }

    void TriggerEnter(Collider2D col)
    {
        Debug.Log("a");
    }
}
