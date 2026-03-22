using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
                print("You Win");
            }
            else
            {
                print("Cheater!");
            }
        }
    }
}
