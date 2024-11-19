using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject keyObject = GameObject.FindWithTag("key");
            if (keyObject != null)
            {
            }
            else
            {
                SceneManager.LoadScene("Scene 2");
            }

            // This will do the same thing.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
