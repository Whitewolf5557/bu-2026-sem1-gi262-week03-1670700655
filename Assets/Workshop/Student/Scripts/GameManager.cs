using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject winPanel;

    private bool gameWon = false;

    private void Awake()
    {
        Instance = this;

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }
    }

    public void WinGame()
    {
        if (gameWon)
            return;

        gameWon = true;

       

        if (winPanel != null)
        {
            winPanel.SetActive(true);
     
        }

        Time.timeScale = 0f;
    }
}
