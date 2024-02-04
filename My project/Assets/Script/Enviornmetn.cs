using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Enviornmetn : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(Renderer renderer in GetComponentsInChildren<Renderer>())
        {
            renderer.material.color = Color.red;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
