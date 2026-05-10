using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("You Died!");
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
        else if (collision.gameObject.CompareTag("Shell"))
        {
            Debug.Log(collision);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
