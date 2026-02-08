using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telepor : MonoBehaviour
{
    public int enemyCount;

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        Debug.Log(collision);
        if (collision.gameObject.tag == "Player" && enemyCount == 0)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

}
