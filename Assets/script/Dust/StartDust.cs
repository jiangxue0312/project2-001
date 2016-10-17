using UnityEngine;
using System.Collections;

public class StartDust : MonoBehaviour {

    public ParticleSystem ps;

    // Use this for initialization
    void Start () {
        var emission = ps.emission;
        emission.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Prefab/Moles"))
        {
            var emission = ps.emission;
            Debug.Log("Start Particle");
            emission.enabled = true;
        }
    }

}
