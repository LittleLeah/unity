using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public float forceApplied = 5000;
    public float Radius = 5.0F;
    public float Power = 10.0F;


    void OnCollisionEnter(Collision col)
    {

    Debug.Log("Collision!");
        if (col.gameObject.name == "Remains")
        {
            Vector3 Explostionpos = transform.position;
            col.gameObject.GetComponent<Rigidbody>().AddExplosionForce(Power, Explostionpos, Radius, 3.0F);
        }
    }
}
