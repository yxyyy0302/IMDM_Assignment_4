using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TransitionOne : MonoBehaviour
{
    public TextMeshProUGUI introText;
    public float displayDuration = 30f;

    void Start()
    {
        if (introText != null)
        {
            introText.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Scene 2");
    }
}
