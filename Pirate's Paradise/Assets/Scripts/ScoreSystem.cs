using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public int minScore = 0;

    private void Awake()
    {
        
        DontDestroyOnLoad(this.gameObject);
    }

    public void AddScore(int points)
    {
        score += points;

        if (score < minScore)
        {
            
        }
    }
}