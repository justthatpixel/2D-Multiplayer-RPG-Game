

using UnityEngine;

public class HealthSystem :MonoBehaviour
{
    public float currentHealth;
    public int maxHealth;
    private int health;
    private bool flashActive;
    [SerializeField]
    private float flashLength = 0f;
    private float flashCounter = 0f;
    private SpriteRenderer PlayerSprite;

    public HealthSystem(int health)
    {
        this.health = health;

    }
    private void Start()
    {
        PlayerSprite = GetComponent<SpriteRenderer>();
    }
     void Update()
    {
        if (flashActive)
        {


            if (flashCounter > flashLength * .99f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 0f);

            }
            else if (flashCounter > flashLength * .82f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 1f);

            }
            else if (flashCounter > flashLength * .66f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 1f);

            }
            else if (flashCounter > flashLength * .49f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 0f);

            }
            else if (flashCounter > flashLength * .33f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 1f);

            }
            else if (flashCounter > flashLength * .16f)
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 0f);

            }
            else
            {
                PlayerSprite.color = new Color(PlayerSprite.color.r, PlayerSprite.color.g, PlayerSprite.color.b, 1f);
                flashActive = false;
            }




        }
        flashCounter -= Time.deltaTime;
    }


    public void HurtPlayer(int damagetoGive)
    {
        currentHealth -= damagetoGive;
        flashActive = true;
        flashCounter = flashLength;

        

    }
    //reference to heal
    public void HealPlayer(int AmountToheal)
    {
        currentHealth = 30;

    }
  
    
}
