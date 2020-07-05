using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public Animator myAnim;
    private Transform player;
    [SerializeField]
    public float skele_speed=20;
    [SerializeField]
    public float minrange;
    void Start()
    {

        myAnim = GetComponent<Animator>();
        player = FindObjectOfType<script>().transform;

    }

    // Update is called once per frame
    void Update()
    {

        //if (Vector3.Distance(player.position, transform.position) <= range) DOES NOT WORK. RANGE FOR SKELETON

            FollowPlayer();
       

    }
    public void FollowPlayer()
        //follow player and reference animator. Check if moving.
    {
        myAnim.SetBool("IsMoving",true);
        myAnim.SetFloat("MoveX", (player.position.x - transform.position.x));
        myAnim.SetFloat("MoveY", (player.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, skele_speed * Time.deltaTime);
    }
    // if skeleton is attacked gets knocked back
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag=="MyWeapon")
        {
            Vector2 difference = transform.position - collision.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
        }
    }
}
