using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public void reload()
    {
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.CompareTag("Player"))
        {
            print("You Died!");
            SceneManager.LoadScene(1);
            
        }
        else if (collision.gameObject.CompareTag("Shell"))
        {
            Debug.Log(collision);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
