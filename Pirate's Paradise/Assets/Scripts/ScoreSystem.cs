using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public int minScore = 0; 

    

    public void AddScore(int points)
    {
        score += points;

        if (score < minScore)
        {
           
            SceneManager.LoadScene("GameOver");
        }
    }
}