using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float laserSpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.up * laserSpeed;
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
