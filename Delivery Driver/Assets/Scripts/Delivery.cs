using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!!!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;
        }
        else if (other.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}
