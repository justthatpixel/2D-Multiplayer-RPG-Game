using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    private HealthSystem healthMan;
    public Slider healthBar;
    public TextMeshPro hpText;


    // Start is called before the first frame update
    void Start()
    {
        healthMan = FindObjectOfType<HealthSystem>();
        
    }

    // Update is called once per frame

        //DONT HAVE TO ADD NUMBERS TO your Health
    void Update()
    {
        healthBar.maxValue = healthMan.maxHealth;
        healthBar.value = healthMan.currentHealth;
    }
}
