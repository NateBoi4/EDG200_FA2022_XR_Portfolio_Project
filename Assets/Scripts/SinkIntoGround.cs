using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkIntoGround : MonoBehaviour
{
    public float movementSpeed = 0.25f;
    public void Update()
    {
        float xPos = gameObject.transform.position.x;
        float yPos = gameObject.transform.position.y;
        float zPos = gameObject.transform.position.z;
        yPos -= movementSpeed * Time.deltaTime;
        Vector3 newPos = new Vector3(xPos, yPos, zPos);

        gameObject.transform.position = newPos;
    }
}
