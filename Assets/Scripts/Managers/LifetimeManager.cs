using UnityEngine;

public class LifetimeManager : MonoBehaviour
{
    [SerializeField] Move move;
    [SerializeField] GameObject body;
    [SerializeField] GameObject apple;
    void OnEnable()
    {
        EventManager.AddListener<GameObject>("OnAppleCollected", OnAppleCollected);
        EventManager.AddListener<GameObject>("OnBodyHit", OnBodyHit);
    }

    void OnDisable()
    {
        EventManager.RemoveListener<GameObject>("OnAppleCollected", OnAppleCollected);
        EventManager.RemoveListener<GameObject>("OnBodyHit", OnBodyHit);
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
    void OnBodyHit(GameObject o)
    {
        Debug.Log("HİT !" + o.gameObject.name);
    }

    void CloneAppleRandomly()
    {
        float randomX = Random.Range(-20, 21) * 0.4f;
        float randomY = Random.Range(-10, 11) * 0.4f;

        Instantiate(apple, new Vector3(randomX, randomY, 1f), Quaternion.identity);
    }
}
