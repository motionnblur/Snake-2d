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
        if (col.CompareTag("Apple"))
        {
            EventManager.TriggerEvent("OnAppleCollected", col.gameObject);
        }
        else if (col.CompareTag("Body"))
        {
            //EventManager.TriggerEvent("OnBodyHit", col.gameObject);
            EventManager.TriggerEvent("OnGameEnd");
        }
    }
}
