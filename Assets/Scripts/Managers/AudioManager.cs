using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource aud;
    void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
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
        aud.Play();
    }
}
