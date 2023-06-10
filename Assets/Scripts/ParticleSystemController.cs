using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public GameObject ps;

    public void EnableParticleSystem()
    {
        if(ps)
            ps.SetActive(true);
    }
    
    public void DisableParticleSystem()
    {
        if(ps)
            ps.SetActive(false);
    }
}
