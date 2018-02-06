using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOffWall : MonoBehaviour {

    public float forceXApplied = 10;
    public float forceZApplied = 10;


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        if (col.gameObject.name =="Sphere")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(forceXApplied, 0, forceZApplied);
            col.gameObject.GetComponent<Rigidbody>().AddTorque(0, 0, 300);
        }
    }
}
