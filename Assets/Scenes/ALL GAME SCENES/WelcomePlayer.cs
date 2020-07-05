using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomePlayer : MonoBehaviour
{
    public  string nameof;
    public GameObject textdisplay;
    void start()
    {


        
        textdisplay.GetComponent<Text>().text = nameof + "welcome Player";
    }

    
}
