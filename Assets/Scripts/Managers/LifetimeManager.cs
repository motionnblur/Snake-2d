using UnityEngine;

public class LifetimeManager : MonoBehaviour
{
    [SerializeField] GameObject body;
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
        Instantiate(body, o.transform.position, Quaternion.identity);
        Destroy(o);
    }
}
