using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLid : MonoBehaviour
{
    public GameObject lid;

    public void Open()
    {
        //lid.transform.Translate(new Vector3(0.0f, 1.4f, -0.4f));
        lid.transform.Rotate(new Vector3(-90.0f, 0.0f, 0.0f));
    }

    public void Close()
    {
        //lid.transform.Translate(new Vector3(0.0f, 1.281406f, -0.4452634f));
        lid.transform.Rotate(new Vector3(90.0f, 0.0f, 0.0f));
    }
}
