using UnityEngine;

public class LifetimeManager : MonoBehaviour
{
    [SerializeField] Move move;
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
        GameObject newTail = Instantiate(body, o.transform.position, Quaternion.identity);
        move.tails.Add(newTail);
        Destroy(o);
    }
}
