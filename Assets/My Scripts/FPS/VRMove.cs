using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMove : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    private GameObject camera;


    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            transform.position += Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up).normalized * Time.deltaTime * speed;
        }
    }
}
