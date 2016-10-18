using UnityEngine;
using System.Collections;

public class EndDust : MonoBehaviour {


    public ParticleSystem ps;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Prefab/Moles"))
        {
            var emission = ps.emission;
            Debug.Log("End Particle");
            emission.enabled = false;
        }
    }
}
