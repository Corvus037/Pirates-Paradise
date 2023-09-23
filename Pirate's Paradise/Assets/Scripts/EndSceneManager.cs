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
        // Verifica se o ScoreSystem já existe na cena atual.
        ScoreSystem scoreSystem = FindObjectOfType<ScoreSystem>();
        
        if (scoreSystem != null)
        {
            // Atualiza o valor dos pontos no objeto existente.
            scoreSystem.AddScore(0); // Valor zero apenas para atualizar a exibição.

            // Carrega a cena "Game".
            SceneManager.LoadScene("Game");
        }
        else
        {
            // Caso não encontre o ScoreSystem na cena, apenas carrega a cena "Game".
            SceneManager.LoadScene("Game");
        }
    }
}