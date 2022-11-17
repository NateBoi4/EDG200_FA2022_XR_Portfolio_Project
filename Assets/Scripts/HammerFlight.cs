using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HammerFlight : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public InputActionReference movement;
    public GameObject Hammer;
    public bool held;

    void Start()
    {
        //movement.action.performed += Fly;
        held = false;
    }

    void Update()
    {
        if (movement.action.IsPressed())
        {
            HammerThrow checkHandle = Hammer.GetComponent<HammerThrow>();
            if (checkHandle)
            {
                if (held)
                    transform.position += Hammer.transform.up * Time.deltaTime * movementSpeed;
            }
        }
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position -= Hammer.transform.up * Time.deltaTime * movementSpeed;
        //}
    }

    public void Hold()
    {
        held = true;
    }

    public void Release()
    {
        held = false;
    }

    public void Fly(InputAction.CallbackContext context)
    {
        HammerThrow checkHandle = Hammer.GetComponent<HammerThrow>();
        if (checkHandle)
        {
            if(held)
                transform.position += Hammer.transform.up * Time.deltaTime * movementSpeed;
        }
    }
}
