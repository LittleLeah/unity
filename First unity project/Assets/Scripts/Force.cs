using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public float forceApplied = 5000;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        if (col.gameObject.name == "Sphere")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forceApplied);
        }
    }
}
