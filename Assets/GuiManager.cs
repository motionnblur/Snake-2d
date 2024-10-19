using UnityEngine;

public class GuiManager : MonoBehaviour
{
    [SerializeField] GameObject GameEndUi;

    void OnEnable()
    {
        EventManager.AddListener("OnGameEnd", OnGameEnd);
    }

    void OnDisable()
    {
        EventManager.RemoveListener("OnGameEnd", OnGameEnd);
    }

    void OnGameEnd()
    {
        GameEndUi.SetActive(true);
    }
}
