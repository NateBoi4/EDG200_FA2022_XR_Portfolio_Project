using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HammerState
{
    INVALID_STATE = -1,
    THROW_STATE = 0,
    RETURN_STATE = 1,
    IDLE_STATE = 2
}

public class HammerThrow : MonoBehaviour
{
    HammerState state;
    Rigidbody rb;

    public Transform playerHand;

    public float throwMultiplier = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        state = HammerState.IDLE_STATE;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case HammerState.IDLE_STATE:
                break;
            case HammerState.RETURN_STATE:
                //Debug.Log("returning");
                if (Vector3.SqrMagnitude(playerHand.position - transform.position) > 16)
                {
                    Vector3 dir = (playerHand.position - transform.position).normalized;
                    rb.velocity = dir * throwMultiplier;
                }
                else
                {
                    state = HammerState.IDLE_STATE;
                }
                break;
            case HammerState.THROW_STATE:
                rb.velocity = rb.velocity.normalized * throwMultiplier;
                break;
            default:
                break;
        }
    }

    public void ThrowHammer()
    {
        state = HammerState.THROW_STATE;
    }

    public void ReturnHammer()
    {
        state = HammerState.RETURN_STATE;
    }

    public void IdleHammer()
    {
        state = HammerState.IDLE_STATE;
    }
}
