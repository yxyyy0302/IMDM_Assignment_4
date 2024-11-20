using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        
          if (other.tag == "Player")
        {
            GameObject appleObject = GameObject.FindWithTag("apple");
            if (appleObject != null)
            {
            }
            else
            {
                SceneManager.LoadScene("Scene 3");
            }

            // This will do the same thing.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }


}


