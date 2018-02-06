using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

    public GameObject remains;

    // Update is called once per frame
    void Update () {

	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        if (col.gameObject.name == "Cube")
        {
            Instantiate(remains, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
