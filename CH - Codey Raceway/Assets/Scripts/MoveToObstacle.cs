using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObstacle : MonoBehaviour
{
    public GameObject[] obstacle;
    public Vector3 player;
    private GameObject target;
    private GameObject finalTarget = null;
    private NavMeshAgent agent;
    public float closestdistance;

    private void Start()
    {
        obstacle = GameObject.FindGameObjectsWithTag("obstacle");
        closestdistance = 100000f;
        finalTarget = obstacle[0];
        player = GameObject.FindGameObjectWithTag("Player").transform.position;
        agent = GetComponent<NavMeshAgent>();
        foreach (GameObject target in obstacle)
        {
            float dist = Vector3.Distance(target.transform.position, transform.position);
            if (dist < closestdistance)
            {
                closestdistance = dist;
                finalTarget = target;
            }
        }
        agent.destination = finalTarget.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log(collision);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
