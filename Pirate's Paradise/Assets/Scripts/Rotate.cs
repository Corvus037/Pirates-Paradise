using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 0f;

           
            Vector3 lookDirection = (touchPosition - transform.position).normalized;

            
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, lookDirection);

            
            transform.rotation = rotation;
        }
    }
}