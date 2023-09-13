using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] squares; 
    public Sprite[] sprites;     
    public float changeInterval = 3f; 

    private float timer = 0f;
    private int currentIndex = -1;

    private void Start()
    {
        
        timer = changeInterval;

        
        foreach (var square in squares)
        {
            square.GetComponent<SpriteRenderer>().sprite = null;
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            
            if (currentIndex >= 0 && currentIndex < squares.Length)
            {
                squares[currentIndex].GetComponent<SpriteRenderer>().sprite = null;
            }

           
            currentIndex = Random.Range(0, squares.Length);

            
            if (currentIndex >= 0 && currentIndex < sprites.Length)
            {
               
                squares[currentIndex].GetComponent<SpriteRenderer>().sprite = sprites[currentIndex];
            }
            else
            {
                Debug.LogError("Não há sprites suficientes para atribuir aos quadrados.");
            }

            
            timer = changeInterval;
        }
    }
}