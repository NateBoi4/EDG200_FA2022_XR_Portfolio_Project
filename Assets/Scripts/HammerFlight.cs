using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HammerFlight : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public InputActionReference movement;
    public GameObject Hammer;

    void Start()
    {
        movement.action.performed += Fly;
    }

    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        transform.position += Hammer.transform.up * Time.deltaTime * movementSpeed;
    //    }
    //    else if (Input.GetKey(KeyCode.S))
    //    {
    //        transform.position -= Hammer.transform.up * Time.deltaTime * movementSpeed;
    //    }
    //}

    public void Fly(InputAction.CallbackContext context)
    {
        HammerThrow checkHandle = Hammer.GetComponent<HammerThrow>();
        if (checkHandle)
        {
            if(checkHandle.held)
                transform.position += Hammer.transform.up * Time.deltaTime * movementSpeed;
        }
    }
}
