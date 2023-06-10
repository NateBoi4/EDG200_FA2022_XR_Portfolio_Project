using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private GameObject startPoint;
    [SerializeField] private GameObject endPoint;

    [SerializeField] private float distance;

    private void Update()
    {
        RaycastHit hit;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(startPoint.transform.position, fwd, out hit, distance))
        {
            endPoint.transform.position = hit.point;
        }
        else
        {
            //endPoint.transform.position = startPoint.transform.position + new Vector3(0.0f, 0.0f, 20.0f);
        }
    }
}
