using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }
}
