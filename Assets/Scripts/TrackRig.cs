using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRig : MonoBehaviour
{
    [SerializeField] private GameObject Rig;

    public GameObject GetRig() { return Rig; }

    // Update is called once per frame
    void Update()
    {
        transform.position = 
            new Vector3(Rig.transform.position.x, transform.position.y, Rig.transform.position.z);
    }
}
