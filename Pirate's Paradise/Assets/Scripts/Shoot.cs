using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public float ProjectileSpeed;
    public Transform gunTip; 

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            clickPosition.z = 0f;

            Vector3 shootDirection = (clickPosition - gunTip.position).normalized;

            float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

            gunTip.rotation = Quaternion.Euler(0, 0, angle);

            GameObject projectile = Instantiate(ProjectilePrefab, gunTip.position, Quaternion.identity);

            projectile.GetComponent<Rigidbody>().velocity = shootDirection * ProjectileSpeed;
        }
    }
}