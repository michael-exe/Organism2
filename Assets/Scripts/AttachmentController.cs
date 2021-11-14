using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttachmentController : MonoBehaviour
{
    //DETECTOR(ext) 
    public Transform UR_Detector;
    public Transform UL_Detector;
    public Transform DR_Detector;
    public Transform DL_Detector;
    //HOLDER(int)
    public Transform UR_Holder;
    public Transform UL_Holder;
    public Transform DR_Holder;
    public Transform DL_Holder;
    
    public Collider2D MembraneCollider;

    // Update is called once per frame
    void Update()
    {
        ALL_Attach(UR_Detector.position,UR_Holder);
        ALL_Attach(UL_Detector.position,UL_Holder);
        ALL_Attach(DR_Detector.position,DR_Holder);
        ALL_Attach(DL_Detector.position,DL_Holder);
        Level_1();
        //Win();
    }

    void ALL_Attach(Vector2 pos,Transform _holder){

    RaycastHit2D Ext2Int = Physics2D.Raycast(pos, Vector2.zero, 0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Ext_Molecule")
        {
            Ext2Int.collider.transform.parent = _holder;
            Ext2Int.collider.gameObject.transform.position = _holder.position;
            Ext2Int.collider.gameObject.tag = "Int_Molecule";

             FindObjectOfType<Player>().objectGrabed.Add(Ext2Int.collider.gameObject);

        }
    }

    void Level_1 ()
    {
        if (UR_Holder.childCount == 1 && UL_Holder.childCount == 1 && DR_Holder.childCount == 1 && DL_Holder.childCount == 1)
        {
            MembraneCollider.enabled = true;
        }
        else 
        {
            MembraneCollider.enabled = false;
        }
    }

    //void Win()
    //{
    //    if (MembraneCollider != null && MembraneCollider.tag == "Int_Molecule")
    //    {
    //        SceneManager.LoadScene("Organism");
    //    }

    //}
}
//https://youtu.be/U8gUnpeaMbQ Snake
//https://youtu.be/1uq43EIzo-U Grab
//https://youtu.be/cIeWhztKyAg Asteroids
//https://youtu.be/VbZ9_C4-Qbo GameOver
// First of all it is very bad practice to execute GetComponent or FindGameObjectWithTag inside the Update method. Please do this on Awake or Start.
//https://answers.unity.com/questions/1169975/referencing-variable-from-another-script-on-anothe.html