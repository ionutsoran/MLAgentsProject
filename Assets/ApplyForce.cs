using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().velocity = Vector3.up*0.5f;
        if (transform.position.y < 5f)
            GetComponent<Rigidbody>().AddForce(Vector3.up * force);
        else
            GetComponent<Rigidbody>().AddForce(Vector3.up * -force);
    }

    public void applyforcepoz()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up*force);
    }

    public void applyforceneg()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * -force);
    }
}
