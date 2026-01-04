using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crusher1 : MonoBehaviour
{
    public float speed;
    public Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

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
            speed *= -1;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (scene.name == "Level2")
            {
                SceneManager.LoadScene("Level2");
                //scene.name = "Level2";
            }
            else
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
