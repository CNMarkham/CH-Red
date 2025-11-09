using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    void Start()
    {
        
    }

    void Update()
    {
        offset = new Vector3(1, 0, 0);
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(objectThrown, transform.position, transform.rotation);
        }
    }
}
