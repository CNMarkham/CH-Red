using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win");
            }
            else
            {
                print("Cheater!");
            }
        }
    }
}
