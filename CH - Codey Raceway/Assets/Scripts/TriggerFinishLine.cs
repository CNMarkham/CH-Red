using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiggerFinishLine : MonoBehaviour
{
    public Text winText;
    public CheckpointCounter checkpointTracker;
    private void Start()
    {
        winText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                winText.enabled = true;
                SceneManager.LoadScene(1);
            }
            else
            {
                print("Cheater!");
                SceneManager.LoadScene(0);
            }
        }
    }
}
