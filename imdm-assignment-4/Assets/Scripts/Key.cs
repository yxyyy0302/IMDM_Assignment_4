using UnityEngine;

public class Key : MonoBehaviour
{
    [Header("Effects")]
    public GameObject particleEffectPrefab;

    [Header("Motion Settings")]
    public float bobbingAmount = 0.01f;
    public float bobbingSpeed = 0.001f;    

    private Vector3 startPosition;
    private float timer;

    public bool got = false;

    void Start()
    {
        startPosition = transform.position;
        timer = Random.Range(0f, Mathf.PI * 2);
    }

    void Update()
    {
        timer += Time.deltaTime * bobbingSpeed;
        float newY = startPosition.y + Mathf.Sin(timer) * bobbingAmount;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Instantiate the particle effect
            if (particleEffectPrefab != null)
            {
                Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
            }

            got = true;
            Destroy(gameObject);
        }
    }
}
