using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    private Button[] buttons;

    void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        HideButtons();
    }

    public void HideButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void ShowButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ExitToMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void RestartGame()
    {
        Application.LoadLevel("Stage1");
    }
}