using UnityEngine;

public class RockingHorse : MonoBehaviour
{
    public float degreesPerSecond = 1f;  // Rotation speed
    public float minAngle = -100f;         // Minimum angle
    public float maxAngle = -80f;          // Maximum angle
    private float currentAngle;             // Current angle of the rocking horse
    private bool goingUp = true;            // Direction of rotation

    void Start()
    {
        currentAngle = minAngle;            // Start at the minimum angle
        transform.rotation = Quaternion.Euler(currentAngle, 0, 0); // Set the initial rotation
    }

    private void Update()
    {
        // Update the angle based on the current direction
        if (goingUp)
        {
            currentAngle += degreesPerSecond * Time.deltaTime; // Increase angle
            if (currentAngle >= maxAngle) // Check if max angle is reached
            {
                currentAngle = maxAngle; // Clamp to max angle
                goingUp = false; // Change direction
            }
        }
        else
        {
            currentAngle -= degreesPerSecond * Time.deltaTime; // Decrease angle
            if (currentAngle <= minAngle) // Check if min angle is reached
            {
                currentAngle = minAngle; // Clamp to min angle
                goingUp = true; // Change direction
            }
        }

        // Apply the rotation
        transform.rotation = Quaternion.Euler(currentAngle, 0, 0);
    }
}
