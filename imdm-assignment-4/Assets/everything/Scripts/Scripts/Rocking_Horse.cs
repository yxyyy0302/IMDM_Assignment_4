using UnityEngine;

public class RockingHorse : MonoBehaviour
{
    public float degreesPerSecond = 1f;  
    public float minAngle = -100f;         
    public float maxAngle = -80f;          
    private float currentAngle;             
    private bool goingUp = true;            

    void Start()
    {
        currentAngle = minAngle;            
        transform.rotation = Quaternion.Euler(currentAngle, 0, 0);
    }

    private void Update()
    {
        if (goingUp)
        {
            currentAngle += degreesPerSecond * Time.deltaTime;
            if (currentAngle >= maxAngle)
            {
                currentAngle = maxAngle;
                goingUp = false;
            }
        }
        else
        {
            currentAngle -= degreesPerSecond * Time.deltaTime;
            if (currentAngle <= minAngle)
            {
                currentAngle = minAngle;
                goingUp = true;
            }
        }

        transform.rotation = Quaternion.Euler(currentAngle, 0, 0);
    }
}
