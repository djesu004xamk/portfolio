using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class Counters : MonoBehaviour
{
    GameObject killcount;
    GameObject timer;

    public float time = 0;
    public int killed = 0;

    void Start()
    {
        // Haetaan muuttujiin laskuriobjektit
        timer = GameObject.Find("Timer");
        killcount = GameObject.Find("KillCount");
    }

    void Update()
    {
        // Aikalaskuri
        time += Time.deltaTime;
        timer.GetComponent<TextMeshProUGUI>().text = "Time: " + time.ToString("0.00");

        // Tappolaskuri
        killcount.GetComponent<TextMeshProUGUI>().text = "Killed: " + killed;
    }
}
