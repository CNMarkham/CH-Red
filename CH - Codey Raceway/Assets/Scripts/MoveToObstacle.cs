using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObstacle : MonoBehaviour
{
    public Transform player;
    public GameObject[] obstacle = GameObject.FindGameObjectsWithTag("obstacle");
    private GameObject target;
    private GameObject finalTarget;
    private NavMeshAgent agent;

    public void obstacleDistance()
    {
        Vector3 offset = player.transform.position - 
    }
    private void Start()
    {
        finalTarget.transform.position = new Vector3(obstacle[0]);
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = obstacle.transform.position;
        foreach (GameObject target in obstacle)
        {
            if (target.transform < finalTarget.transform)
            {
                finalTarget = target;
            }
        }
    }


}
