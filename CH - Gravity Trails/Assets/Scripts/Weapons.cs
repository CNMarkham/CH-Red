using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Weapons : MonoBehaviour
{
    private Animator animator;
    public float speed = 5f;
    public Collider2D c;
    public Transform player;
    public Vector3 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        c = GetComponent<BoxCollider2D>();
        playerDirection = GameObject.FindGameObjectWithTag("Player").transform.localScale;
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            c.enabled = true;
            animator.SetTrigger("Attack");
            Invoke("EndCollider", 1.05f);
        }
        transform.position = player.transform.position;
        //transform.localScale = new Vector3(transform.localScale.x, player.transform.localScale.y * 0.5f, transform.localScale.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + -1, transform.position.z);
        }
    }

    void EndCollider ()
    {
        c.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
