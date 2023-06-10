using DigitalRuby.LightningBolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{

    [SerializeField] private GameObject lightning;

    private bool toggle;

    // Update is called once per frame
    void Update()
    {
        if (lightning.GetComponent<LightningBoltScript>().Charge > 0.0f)
        {
            toggle = lightning.GetComponent<LightningBoltScript>().ManualMode;
            gameObject.GetComponent<BoxCollider>().enabled = !toggle;
        }
        else
            gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
