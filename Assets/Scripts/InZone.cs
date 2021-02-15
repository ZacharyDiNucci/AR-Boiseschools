using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InZone : MonoBehaviour
{
    public ARBusController busController;
    public void OnTriggerEnter(Collider other){
        busController.inZone = true;
        Debug.Log("Triggered!");
    }
}
