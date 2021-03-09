using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InZone : MonoBehaviour
{
    public ARBusController busController;
    void awake(){
        ARBusController[] busController = FindObjectsOfType<ARBusController>();
    }
    public void OnTriggerEnter(Collider other){
        busController.inZone = true;
        Debug.Log("Triggered!");
    }
    public void OnTriggerExit(Collider other){
        busController.inZone = false;
        Debug.Log("Triggered!");
    }
}
