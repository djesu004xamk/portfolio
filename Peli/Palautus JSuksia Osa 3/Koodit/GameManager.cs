using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Seurataan pelaajan liikettä
    #region Singelton

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

}
