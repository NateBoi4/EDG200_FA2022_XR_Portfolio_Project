using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearOverTime : MonoBehaviour
{
    public int lifeTime = 1;
    public void Remove() { Destroy(gameObject, lifeTime); }
}
