using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (String.Equals(other.gameObject.tag, "Player"))
        {
            Debug.Log("pickup collected");
            Destroy(this.gameObject);
        }
    }
}
