using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject GameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreAdd)
    {
        playerScore = playerScore + scoreAdd;
        score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
