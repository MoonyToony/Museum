using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Implode : MonoBehaviour
{
    public GameObject fractured;
    public float breakForce;
    public void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            GameObject frac = Instantiate(fractured, transform.position, transform.rotation);
            //This is weird and makes the rock stay there for some reason.
            //GetComponent<Rigidbody>().AddExplosionForce(250, transform.position, 5);
            Destroy(gameObject);
        }
    }
}
