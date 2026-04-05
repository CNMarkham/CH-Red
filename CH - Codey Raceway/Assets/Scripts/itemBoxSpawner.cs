using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;

    public int xOffset;
    public int zOffset;
    
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject itemBoxClones = Instantiate(itemBox,
                new Vector3(
                    transform.position.x + xOffset * i,
                    transform.position.y,
                    transform.position.z + zOffset * i
                    ),
                Quaternion.identity);
        }
    }

    void Update()
    {

    }
}
