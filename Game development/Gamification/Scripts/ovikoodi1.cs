using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovikoodi1 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //E-näppäin avaa oven

        if (Input.GetKeyDown(KeyCode.E)) {

            this.GetComponent<Animator>().SetInteger("ovitila1", 1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            this.GetComponent<Animator>().SetInteger("ovitila1", 0);
        }
    }
}
