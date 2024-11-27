using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float firerate = 15f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource gunSound;

    private float nextFire = 0f;

    void Update()
    {
        // Asetetaan tietylle n‰pp‰imelle toiminto ampua sek‰ ampumistiheys
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFire)
        {
            nextFire = Time.time + 1f / firerate;
            Shoot();
        }
    }

    // Metodi ampumiselle
    void Shoot()
    {
        // Partikkeliefektej‰
        muzzleFlash.Play();
        gunSound.Play();

        // Ammunnan yhteydess‰ "ammutaan" s‰de
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            // Mik‰li ammunnan kohde sis‰lt‰‰ "Target" komponentin, tuotetaan objektille vahinkoa
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            // Luodaan ja tuhotaan pertikkeliefekti
            GameObject impactObject = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactObject, 0.5f);
        }
    }
}
