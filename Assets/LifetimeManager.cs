using UnityEngine;

public class LifetimeManager : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.AddListener<GameObject>("OnAppleCollected", OnAppleCollected);
    }

    void OnDisable()
    {
        EventManager.RemoveListener<GameObject>("OnAppleCollected", OnAppleCollected);
    }

    void OnAppleCollected(GameObject o)
    {
        Destroy(o);
    }
}
