using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerFinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("You Win");
        }
    }
}
