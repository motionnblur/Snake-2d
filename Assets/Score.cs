using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;

    void OnEnable()
    {
        EventManager.AddListener("OnAppleCollected", OnAppleCollected);
    }
    void OnDisable()
    {
        EventManager.RemoveListener("OnAppleCollected", OnAppleCollected);
    }

    void OnAppleCollected()
    {
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString();
    }
}
