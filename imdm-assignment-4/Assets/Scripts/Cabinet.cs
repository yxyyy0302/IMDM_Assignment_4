using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : MonoBehaviour
{
    public bool isHiding = false;

   private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           isHiding = true;
        }
    }

     private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
           isHiding = false;
        }
    }
}
