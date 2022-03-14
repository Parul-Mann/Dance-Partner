using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems; 
using UnityEngine.XR.ARFoundation;
public class ObjectManager : MonoBehaviour
{
    public GameObject arObject;
    public ARRaycastManager raycastManager;

    void Start()
    {
        arObject.SetActive(false);
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {

            Touch touch0 = Input.GetTouch(0); 
            List<ARRaycastHit> allHits = new List<ARRaycastHit> ();
            if (touch0.phase==TouchPhase.Began)
            {
                 if(raycastManager.Raycast(touch0.position, allHits, TrackableType.Planes))
                {
                    arObject.transform.position = allHits[0].pose.position;
                    arObject.SetActive(true);
                }

    
            }
        }
    }
}
