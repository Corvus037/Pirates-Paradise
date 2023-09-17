using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            
            Vector3 touchPosition = Input.GetTouch(0).position;
            touchPosition.z = 10f; 

            
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(touchPosition);

            
            Vector3 lookDirection = targetPosition - transform.position;

            
            transform.rotation = Quaternion.LookRotation(Vector3.forward, lookDirection);
        }
    }
}