using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public ScoreSystem scoreSystem; // Referência ao script ScoreSystem
    private Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        if (scoreSystem != null)
        {
            scoreText.text = "Points: " + scoreSystem.score.ToString();
        }
    }
}