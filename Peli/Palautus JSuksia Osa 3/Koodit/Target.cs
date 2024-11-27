using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;

    public GameObject enemy1;
    public GameObject enemy2;

    Vector3 spawnPos1;
    Vector3 spawnPos2;
    void Start()
    {
        // M‰‰ritet‰‰n vihollisobjektin el‰m‰n aloitusarvo
        health = 100f; 
    }

    void Update()
    {
        // M‰‰ritet‰‰n uudelleen ilmestyvien vihollisten ilmestymisalue
        spawnPos1 = new Vector3(Random.Range(100f, 1600f), 10f, Random.Range(155f, 850f));
        spawnPos2 = new Vector3(Random.Range(100f, 1600f), 10f, Random.Range(155f, 850f));
    }

    // Metodi vahingon tuotolle sek‰ tappolaskurille
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            DieAndRespawn();

            GameObject.Find("Koodivarasto").GetComponent<Counters>().killed++;
           
        }
    }

    //Metodi vihollisen kuolemalle ja uudelleen ilmestymiselle
    void DieAndRespawn()
    {
        Instantiate(enemy1, spawnPos1, Quaternion.identity);
        Debug.Log("Respawn1");
        Instantiate(enemy2, spawnPos2, Quaternion.identity);
        Debug.Log("Respawn2");
        Destroy(gameObject);
        
    }

}
