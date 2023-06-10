using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HammerConnection : MonoBehaviour
{
    public InputActionReference rightPrimaryButton;
    public InputActionReference leftPrimaryButton;
    public HammerThrow hammer;
    // Start is called before the first frame update
    void Start()
    {
        rightPrimaryButton.action.performed += HammerReturn;
        leftPrimaryButton.action.performed += FlyToHammer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HammerReturn(InputAction.CallbackContext context)
    {
        hammer.ReturnHammer();
    }

    void FlyToHammer(InputAction.CallbackContext context)
    {
        hammer.IdleHammer();
        gameObject.transform.position = hammer.transform.position - hammer.transform.forward * 2.0f;
        hammer.ReturnHammer();
    }
}
