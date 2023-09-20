using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float totalTimeInSeconds = 60f; 

    private float currentTime = 0f;
    private int playerScore = 0; 

    void Update()
    {
        
        currentTime += Time.deltaTime;

        
        if (currentTime >= totalTimeInSeconds)
        {
            
            playerScore = FindObjectOfType<ScoreSystem>().score;

            
            SceneManager.LoadScene("End");
        }
    }
    
    public int GetPlayerScore()
    {
        return playerScore;
    }
}