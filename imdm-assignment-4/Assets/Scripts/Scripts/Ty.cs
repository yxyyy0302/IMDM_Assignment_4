using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ty : MonoBehaviour
{
  public Transform player;
    public float speed = 5f; 

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.position += direction * speed * Time.deltaTime;

            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}
