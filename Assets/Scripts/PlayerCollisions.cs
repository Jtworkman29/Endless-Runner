using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Obstacle")
        {
            gameObject.SetActive(false);
        }

        
    }

    




}
