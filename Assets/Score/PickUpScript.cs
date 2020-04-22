using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{

    public GameObject PickUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScorePrinter.scoreValue += 10;
            Debug.Log("collected");
            Destroy(PickUp);
           
            
        }
    }

  
}
