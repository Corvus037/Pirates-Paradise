using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float maxRotationY = 19f; // Ângulo máximo em Y
    public float minRotationY = -17f; // Ângulo mínimo em Y

    private float fixedRotationX = -13.298f;
    private float fixedRotationZ = -0.098f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosition = Input.GetTouch(0).position;
            touchPosition.z = 10f;

            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(touchPosition);

            Vector3 lookDirection = targetPosition - transform.position;

            // Calcula o ângulo em radianos com base na direção do toque.
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

            // Limita o ângulo no eixo Y dentro do intervalo desejado.
            angle = Mathf.Clamp(angle, minRotationY, maxRotationY);

            // Aplica a rotação apenas no eixo Y.
            transform.rotation = Quaternion.Euler(fixedRotationX, angle, fixedRotationZ);
        }
    }
}