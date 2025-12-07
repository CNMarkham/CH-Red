using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCollision : MonoBehaviour
{
    public Scene scene;

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        { 
            if (scene.name == "Level2")
            {
                SceneManager.LoadScene("Level2");
                scene.name = "Level2";
            }
            else
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
