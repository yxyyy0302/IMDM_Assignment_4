using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ty : MonoBehaviour
{
    public Transform player;
    public Transform door;
    public float speed = 5f; 
    private bool isChasing = true;
    public Cabinet[] cabinets; 

    void Update()
    {
        if (IsPlayerHiding())
        {
            isChasing = false;
            MoveToDoor();
        }
        else
        {
            isChasing = true;
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        if (player != null && isChasing)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.position += direction * speed * Time.deltaTime;

            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }

    void MoveToDoor()
    {
        if (door != null)
        {
            Vector3 direction = (door.position - transform.position).normalized;

            transform.position += direction * speed * Time.deltaTime;

            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }

    bool IsPlayerHiding()
    {
        foreach (Cabinet cabinet in cabinets)
        {
            if (cabinet != null && cabinet.isHiding)
            {
                return true;
            }
        }
        return false;
    }
}
