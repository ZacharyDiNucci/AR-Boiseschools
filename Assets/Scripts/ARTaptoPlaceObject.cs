using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTaptoPlaceObject : MonoBehaviour
{
    public GameObject objectToPlace;
    public GameObject placementIndicator;
    private ARRaycastManager arOrigin;

    void Start()
    {
        arOrigin = FindObjectOfType<ARRaycastManager>();
        placementIndicator = transform.GetChild(0).gameObject;
        placementIndicator.SetActive(false);
    }
     
    void Update(){
        //shoot raycast from center of screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arOrigin.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        //if we hit a plane, update the position and rotation
        if(hits.Count > 0){
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
            
            if(!placementIndicator.activeInHierarchy){
                placementIndicator.SetActive(true);
            }
        }
    } 
}