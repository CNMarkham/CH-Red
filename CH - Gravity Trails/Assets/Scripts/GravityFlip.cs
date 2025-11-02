using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1;
            Vector3 newDirection = avatarRigidbody.transform.localScale;
            newDirection.y *= -1;
            avatarRigidbody.transform.localScale = newDirection;
            
        }
    }
}
