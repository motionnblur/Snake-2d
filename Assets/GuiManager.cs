using System.Collections;
using UnityEngine;

public class GuiManager : MonoBehaviour
{
    [SerializeField] GameObject GameEndUi;
    [SerializeField] GameObject RestartButtonUi;

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
        StartCoroutine(HideGameEndUi());
    }

    public void RestartGame()
    {
        EventManager.TriggerEvent("RestartGame");
    }

    IEnumerator HideGameEndUi()
    {
        yield return new WaitForSeconds(0.6f);
        GameEndUi.SetActive(true);
        RestartButtonUi.SetActive(true);
    }
}
