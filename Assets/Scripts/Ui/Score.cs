using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;

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
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString();
    }
}
