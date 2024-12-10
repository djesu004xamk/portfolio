using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        // Astetaan n�pp�imet pelin uudelleen aloitukselle ja lopetukselle voitto/h�vi� sceneen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
