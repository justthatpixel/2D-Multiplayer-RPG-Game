using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HurtPlayer : MonoBehaviour
{
    private HealthSystem healthman;
    public GameObject Player;
    private float waitToLoad = 1f;
    public float waitToHurt = 2f;
    private bool reloading;
    private bool istouching;
    [SerializeField] 
    private int DamageToGive=10; //if you want to change the damage
    // public gameobject player, drag player in to show what object to disable.
    //Player waits 2 seconds then reloads, when skeleton collides with player, player disabled
    private void Start()
    {
        healthman = FindObjectOfType<HealthSystem>();
    }
    void Update() 
    {
        
        if (reloading)
        {
           waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
     
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
        if (istouching)
        {
            waitToHurt -= Time.deltaTime;
            if (waitToHurt <= 0)
            {
                Player.GetComponent<HealthSystem>().HurtPlayer(DamageToGive);
                waitToHurt = 3f;
            }
        }

    }

  



    private void OnCollisionEnter2D(Collision2D collision)
        {
            //WHEN IT COLLIDES WITH THE PLAYER THE PLAYER DISSAPEARS
            {
            if (collision.gameObject == Player )  
                {
                //  Player.SetActive(false);
                Player.GetComponent<HealthSystem>().HurtPlayer(DamageToGive);
               
              
                }

            }
        }
        
    private void FixedUpdate()
    {
        if (Player.GetComponent<HealthSystem>().currentHealth == 0) 
            {
              Player.SetActive(false);
            reloading = true;
            }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //So only the player loses health.
        if (collision.gameObject == Player)
        {
            istouching = true;
        }
    }

    // No poison effect. Loss health stops when exit collision. And wait to hurt resest to 1 second.
      private void OnCollisionExit2D(Collision2D collision)
    {
            if (collision.gameObject == Player)
            {
                istouching = false;
            waitToHurt = 2;
            }


    }


}
   




