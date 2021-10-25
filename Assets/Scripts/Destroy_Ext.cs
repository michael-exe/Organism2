using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Ext : MonoBehaviour
{
    void Update()
    {
        Debug.Log("exhist");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.gameObject.tag == "Int_Molecule")
        {
            Destroy(this.gameObject);
            Debug.Log("collision if");
        }
    }
} //https://youtu.be/LNLVOjbrQj4
