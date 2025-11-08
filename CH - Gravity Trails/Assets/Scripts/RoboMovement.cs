using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboMovement : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        if (transform.position.x <= -32.5 || transform.position.x >= 32.5)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2 (newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
