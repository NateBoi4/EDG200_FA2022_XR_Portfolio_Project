using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KnifeImpact : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
            Debug.Log("hit");
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                if(other.gameObject.GetComponent<TeleportationArea>())
                    player.transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            }
        }
    }

    public void Unfreeze()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
            rb.constraints = RigidbodyConstraints.None;
    }

    public void Duplicate()
    {
        Instantiate(gameObject, transform.position, transform.rotation);
    }
}
