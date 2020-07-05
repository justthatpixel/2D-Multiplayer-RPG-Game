using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TransferName : MonoBehaviour
{
    public  string theName;
    public GameObject inputfield;
    public GameObject textdisplay;
    public string sceneToLoad;
    // public GameObject error;


    public void StoreName()
    {
        
        if (theName.Length >=6)
        {
            theName = inputfield.GetComponent<Text>().text;
            textdisplay.GetComponent<Text>().text = theName + "is not a valid username";
        }
        else if (theName.Length <= 5)
        {
            theName = inputfield.GetComponent<Text>().text;
            textdisplay.GetComponent<Text>().text = theName + "works!";
            SceneManager.LoadScene(sceneToLoad);
        }
        

    }
  
}






