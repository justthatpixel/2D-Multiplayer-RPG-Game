
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class Camera : MonoBehaviour 
  
{
    public Transform player;
    public float smoothing;
    public UnityEngine.Vector2 minposition;
    public UnityEngine.Vector2 maxposition;


    void  LateUpdate()
    {
        transform.position = new UnityEngine.Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        if(transform.position != player.position)
        {
            UnityEngine.Vector3 playerposition = new UnityEngine.Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = UnityEngine.Vector3.Lerp(transform.position, player.position, smoothing);
            //Doesnt clamp to the size of the map for some reasons

            playerposition.x = Mathf.Clamp(player.position.x, minposition.x, maxposition.x);
            playerposition.y = Mathf.Clamp(player.position.y, minposition.y, maxposition.y);
            
        }
    }

}
