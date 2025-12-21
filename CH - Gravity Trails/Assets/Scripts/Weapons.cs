using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Weapons : MonoBehaviour
{
    private Animator animator;
    public Transform player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
    /*    Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            if (player != null)
            {
                float step = speed * Time.deltaTime;

                transform.position = Vector3.MoveTowards(transform.position, player.position, step);
            }
        }*/
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Attack");
        }
    }
}
