using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    //  Tunnistetaan törmäys pelaajan kanssa ja scenen vaihto
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2);
        }
    }
}
