using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerOnHit : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (myEvents == null)
        {
            print("myEventTrigger was triggered but myEvents was null");
        }
        else
        {
            print("MyEventTrigger Activated Triggering" + myEvents);
            myEvents.Invoke();
        }
    }

}
