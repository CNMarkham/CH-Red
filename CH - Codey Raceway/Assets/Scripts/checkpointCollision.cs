using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckpointCounter count;

    void Start()
    {
        didCollide = false;
    }

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Player" && didCollide == false)
        {
            didCollide = true;
            count.triggeredCheckpoints++;
        }
    }
}
