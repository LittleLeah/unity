using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    // Use this for initialization
    public float forceApplied = 10;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        if (col.gameObject.name == "Sphere")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forceApplied);
        }
    }
}
