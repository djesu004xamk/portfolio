using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovihallinta2 : MonoBehaviour
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
            GameObject.Find("ParioviVas").GetComponent<Animator>().SetInteger("ovitilaParioviVas", 1);
            GameObject.Find("ParioviOik").GetComponent<Animator>().SetInteger("ovitilaParioviOik", 1);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("ParioviVas").GetComponent<Animator>().SetInteger("ovitilaParioviVas", 0);
            GameObject.Find("ParioviOik").GetComponent<Animator>().SetInteger("ovitilaParioviOik", 0);
        }

    }
}
