using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public bool walling;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("test" + collisionInfo.collider.name);

        

        if (collisionInfo.collider.tag == "Pillar")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            walling = true;
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Pillar")
        {
            walling = true;
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Floor")
        {

        }
        else 
        collisionInfo.gameObject.GetComponent<Renderer>().material.color = Color.red;
        walling = false;
    }
}
