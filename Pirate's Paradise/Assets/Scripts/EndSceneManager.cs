using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        ScoreSystem scoreSystem = FindObjectOfType<ScoreSystem>();

        if (scoreText != null && scoreSystem != null)
        {
            int playerScore = scoreSystem.score;

            scoreText.text = " Game Ended! Points: " + playerScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}