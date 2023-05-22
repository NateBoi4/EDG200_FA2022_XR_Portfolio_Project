using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputReader : MonoBehaviour
{
    List<InputDevice> inputDevices = new List<InputDevice>();

    private void Start()
    {
        InitializeInputReader();
    }

    private void InitializeInputReader()
    {
        // Get all Devices
        //InputDevices.GetDevices(inputDevices);
        // Get Right Controller
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, inputDevices);

        foreach(var inputDevice in inputDevices) 
        {
            // Log Trigger value
            inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
            Debug.Log(inputDevice.name + " " + triggerValue);

            // Log device info
            //Debug.Log(inputDevice.name + " " + inputDevice.characteristics);
        }
    }

    private void Update()
    {
        if(inputDevices.Count < 2) 
        {
            InitializeInputReader();
        }
    }
}
