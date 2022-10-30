using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private GameObject startPoint;
    [SerializeField] private GameObject endPoint;

    [SerializeField] private float distance = 10;

    private void FixedUpdate()
    {
        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(startPoint.transform.position, fwd, out hit, distance))
        {
            endPoint.transform.position = hit.point;
        }
    }
}
