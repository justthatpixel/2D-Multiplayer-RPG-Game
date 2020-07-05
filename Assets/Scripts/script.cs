using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    
    public Rigidbody2D myrb;
    [SerializeField]
    public float speed = 150;
    public Animator myanimator;
    private Inventory inventory;
  //  [SerializeField] public UI_inventory uiInventory;
    Vector2 movement;
    private float attackTime = .33f;
    private float attackCounter = .33f;
    private bool IsAttacking;

    public float health;
    public Text healthDisplay;



    public void Awake()
    {
        inventory = new Inventory();
    }
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //get input for horizontal and vertical then apply speed.
        
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");




     

        myanimator.SetFloat("Horizontal",movement.x );
        myanimator.SetFloat("Vertical", movement.y);
        myanimator.SetFloat("speed", movement.sqrMagnitude);

        if (IsAttacking)
        {
           myrb.velocity=Vector2.zero;
            attackCounter -= Time.deltaTime;
            if (attackCounter<=0)
            {
                myanimator.SetBool("IsAttacking", false);
                IsAttacking = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            attackCounter = attackTime;
            myanimator.SetBool("IsAttacking", true);
            IsAttacking = true;

        }

    }
    private void FixedUpdate()
    {
        myrb.MovePosition(myrb.position + movement * speed * Time.fixedDeltaTime);

    }
   
        
    

}
