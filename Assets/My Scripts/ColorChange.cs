using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void Red()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void Blue()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
