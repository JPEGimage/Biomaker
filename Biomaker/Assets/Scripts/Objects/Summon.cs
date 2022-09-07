using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{

    public GameObject bird;
    void Start()
    {
        InvokeRepeating("Birds",10f, 25f);
    }
    public void Birds()
    {
        Instantiate(bird, transform.position, bird.transform.rotation);
    }
}
