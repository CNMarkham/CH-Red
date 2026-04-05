using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public float boxRotateSpeed = 50f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, boxRotateSpeed * Time.deltaTime, boxRotateSpeed * Time.deltaTime);
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
        Invoke("itemBoxRespawn", 3f);
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
