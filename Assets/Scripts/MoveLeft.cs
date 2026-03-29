using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float baseSpeed = 5f;

    void Update()
    {
        float currentSpeed = baseSpeed + (Time.timeSinceLevelLoad * 0.2f);

        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);

        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
}