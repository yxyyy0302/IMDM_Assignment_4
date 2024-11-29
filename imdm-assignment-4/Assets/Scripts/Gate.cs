using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    public static Gate Instance;  
    private int applesCollected = 0;  
    public int totalApples = 3; 

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);  
        }
    }

    public void AppleCollected()
    {
        applesCollected++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (applesCollected >= totalApples)
            {
                SceneManager.LoadScene("Transition 2");
            }
        
        }
    }
}
