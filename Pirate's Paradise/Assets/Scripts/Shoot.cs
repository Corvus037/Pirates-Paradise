using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public float projectileSpeed = 10f; 

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
            Vector3 touchPosition = Input.GetTouch(0).position;
            touchPosition.z = 10f; 

            
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(touchPosition);

            
            Vector3 shootDirection = targetPosition - transform.position;

            
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            
            Rigidbody rb = newProjectile.GetComponent<Rigidbody>();
            rb.velocity = shootDirection.normalized * projectileSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("chest"))
        {
            Debug.Log("aiin");
            
            ScoreSystem scoreSystem = FindObjectOfType<ScoreSystem>();

            if (scoreSystem != null)
            {
                
                scoreSystem.AddScore(1);
            }

            
            Destroy(gameObject);
        }
    }
}