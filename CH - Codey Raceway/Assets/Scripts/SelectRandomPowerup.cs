using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public int amountPowerUp;
    public GameObject chosenPowerup;
    public Vector3 codeyPosition;

    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            amountPowerUp += 1;

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && amountPowerUp >= 0)
        {
            codeyPosition = transform.localPosition;
            codeyPosition.y += 1;
            Instantiate(chosenPowerup, codeyPosition + (transform.forward * 3), transform.rotation);
            amountPowerUp -= 1;
        }
    }
}
