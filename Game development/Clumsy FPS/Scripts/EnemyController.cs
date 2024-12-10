using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 30f;

    Transform target;
    NavMeshAgent agent;

    float health;

    void Start()
    {
        target = GameManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        health = GetComponent<Target>().health;

        // Annetaan viholliselle käsky liikkua kohti pelaajaa tämän astuessa tunnistusalueelle
        // tai jos tätä vahingoitetaan
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius || health < 100f)
        {
            agent.SetDestination(target.position);
        }

        // Luodaan virheellisesti ilmaantuneelle vihollisobjektille uudelleen ilmaantumis koodi
        if (transform.position.y < -10)
        {
            Debug.Log("ErrorRespawn");
            Instantiate(gameObject, new Vector3(Random.Range(100f, 1600f), 10f, Random.Range(155f, 850f)), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    // Luodaan visuaalinen tunnitusalue viholliselle
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
