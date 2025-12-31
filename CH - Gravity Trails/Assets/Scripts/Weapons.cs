using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Weapons : MonoBehaviour
{
    private Animator animator;
    public Transform player;
    public float speed = 5f;
    public Collider2D c;
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
        transform.position = player.transform.position + new Vector3(2, 1, 0);
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale *= player.localScale.x;
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
