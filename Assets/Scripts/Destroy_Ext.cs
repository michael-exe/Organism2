using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Ext : MonoBehaviour
{
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Int_Molecule")
        {
            Destroy(this.gameObject);
        }
    }
} //https://youtu.be/LNLVOjbrQj4
