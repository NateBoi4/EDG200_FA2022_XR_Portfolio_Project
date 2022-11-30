using DigitalRuby.LightningBolt;
using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.AI;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent)
        {
            NavMeshPath path = new NavMeshPath();
            agent.CalculatePath(target.position, path);

            // If the path is partial or invalid destroy this agent.
            // Otherwise set the destination.
            if (path.status == NavMeshPathStatus.PathPartial || path.status == NavMeshPathStatus.PathInvalid)
            {
                // We have tried every end point and couldn't get a path so we destroy this object.
                Destroy(gameObject);
            }
            else
            {
                GameObject rig = target.GetComponent<TrackRig>().GetRig();
                if(rig)
                    transform.rotation = Quaternion.LookRotation(rig.transform.position);
                agent.SetDestination(target.position);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hit")
        {
            Destroy(gameObject);
        }
    }
}
