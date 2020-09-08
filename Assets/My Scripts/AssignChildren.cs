using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AssignChildren : MonoBehaviour
{
    public Material mat;
    void Update()
    {
        foreach(Transform child in transform) 
        {
            if (child.GetComponent<MeshChange>() == null) 
            {
                child.gameObject.AddComponent<MeshChange>();
                //child.gameObject.GetComponent<MeshChange>().material = mat;

                child.gameObject.AddComponent<MeshCollider>();
                child.gameObject.AddComponent<EventTriggerExample>();
                //child.gameObject.AddComponent<EventTriggerDelegateExample>();
                //child.gameObject.AddComponent<Rigidbody>();
                //child.gameObject.GetComponent<Rigidbody>().useGravity = false;
                //child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                child.gameObject.AddComponent<EventTrigger>();
            } 
        }
    }

}
