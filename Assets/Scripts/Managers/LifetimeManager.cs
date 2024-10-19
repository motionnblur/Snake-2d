using UnityEngine;

public class LifetimeManager : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] GameObject body;
    [SerializeField] GameObject apple;
    void OnEnable()
    {
        EventManager.AddListener<GameObject>("OnAppleCollected", OnAppleCollected);
    }

    void OnDisable()
    {
        EventManager.RemoveListener<GameObject>("OnAppleCollected", OnAppleCollected);
    }

    void Start()
    {
        CloneAppleRandomly();
    }

    void OnAppleCollected(GameObject o)
    {
        GameObject newTail = Instantiate(body, o.transform.position, Quaternion.identity);
        move.tails.Add(newTail);
        Destroy(o);

        CloneAppleRandomly();
    }

    void CloneAppleRandomly()
    {
        GameObject _apple = Instantiate(apple, new Vector3(0f, 0f, 0f), Quaternion.identity);

        float randomX = Random.Range(-20, 21) * 0.4f;
        float randomY = Random.Range(-10, 11) * 0.4f;

        _apple.transform.position = new Vector3(randomX, randomY, 1f);
    }
}
