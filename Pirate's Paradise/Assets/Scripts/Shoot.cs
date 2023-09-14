using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public Transform gunTip; 

    private void Update()
    {
        
        if (Input.touchCount > 0)
        {
            
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 0f; 

            
            Vector3 shootDirection = (touchPosition - gunTip.position).normalized;

            
            GameObject newProjectile = Instantiate(projectilePrefab, gunTip.position, Quaternion.identity);

            
            Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();

            
            rb.velocity = shootDirection * 10f; 
        }
    }
}