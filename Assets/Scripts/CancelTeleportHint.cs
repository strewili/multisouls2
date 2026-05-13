using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CancelTeleportHint : MonoBehaviour
{

    // Update is called once per frame
    void Start()
    {
        Teleport.instance.CancelTeleportHint();
    }
}