using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ty : MonoBehaviour
{
    public GameObject ty; 
    GameObject[] clones;
    int number = 10;
    const float sponRange = 20;

    void Awake()
    {
        clones = new GameObject[number];
    }

    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            clones[i] = GameObject.Instantiate(ty); 
            clones[i].transform.position = new Vector3(Random.Range(-sponRange, sponRange), 0.5f, Random.Range(-sponRange, sponRange));
            clones[i].transform.rotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }
    }

    void Update()
    {
        for (int i = 0; i < number; i++)
        {
            clones[i].transform.LookAt(this.transform.position); 

            Vector3 target = this.transform.position - clones[i].transform.position;
            clones[i].GetComponent<Rigidbody>().linearVelocity = target.normalized; 
        }
    }
}
