using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes; 
    public float activationInterval = 3f;

    private float timer = 0f;
    private int currentActiveIndex = -1;

    private void Start()
    {
        
        DeactivateAllCubes();

       
        timer = activationInterval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            
            if (currentActiveIndex >= 0 && currentActiveIndex < cubes.Length)
            {
                cubes[currentActiveIndex].SetActive(false);
            }

            
            int randomIndex = Random.Range(0, cubes.Length);

            
            cubes[randomIndex].SetActive(true);

            
            currentActiveIndex = randomIndex;

            
            timer = activationInterval;
        }
    }

    private void DeactivateAllCubes()
    {
        
        foreach (var cube in cubes)
        {
            cube.SetActive(false);
        }
    }
}