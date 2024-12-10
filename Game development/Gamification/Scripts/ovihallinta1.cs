using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovihallinta1 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("P‰‰ovi").GetComponent<Animator>().SetInteger("ovitila1", 1);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("P‰‰ovi").GetComponent<Animator>().SetInteger("ovitila1", 0);
        }

    }
}
