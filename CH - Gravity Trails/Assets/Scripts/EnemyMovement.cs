using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crusher1 : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Surfaces"))
        {
            Debug.Log(collision.gameObject);
            speed *= -1;
        }
    }
}
