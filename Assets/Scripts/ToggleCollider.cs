using DigitalRuby.LightningBolt;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{

    [SerializeField] private GameObject lightning;

    // Update is called once per frame
    void Update()
    {
        bool toggle = lightning.GetComponent<LightningBoltScript>().ManualMode;
        gameObject.GetComponent<BoxCollider>().enabled = !toggle;
    }
}
