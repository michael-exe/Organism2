using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentController : MonoBehaviour
    //really: HolderController
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

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DETECTOR(ext)        
        UR_Attach();
        UL_Attach();
        DR_Attach();
        DL_Attach();
    }

    //DETECTOR(ext) referencing HOLDER(int)
    void UR_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(UR_Detector.position, Vector2.zero, -0);
        //Not really Ext2Int anymore
        
        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Ext_Molecule")
        {
            //Destroy(Ext2Int.collider.gameObject);
            Ext2Int.collider.transform.parent = UR_Holder;
            Ext2Int.collider.transform.position = UR_Holder.position;
            Ext2Int.collider.tag = "Int_Molecule";
        }

    }
    void UL_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(UL_Detector.position,Vector2.zero, -0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Ext_Molecule")
        {
            Ext2Int.collider.transform.parent = UL_Holder;
            Ext2Int.collider.gameObject.transform.position = UL_Holder.position;
            Ext2Int.collider.gameObject.tag = "Int_Molecule";
        }
    }
    void DR_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(DR_Detector.position, Vector2.zero, 0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Ext_Molecule")
        {
            Ext2Int.collider.transform.parent = DR_Holder;
            Ext2Int.collider.gameObject.transform.position = DR_Holder.position;
            Ext2Int.collider.gameObject.tag = "Int_Molecule";
        }
    }
    void DL_Attach()
    {
       
        RaycastHit2D Ext2Int = Physics2D.Raycast(DL_Detector.position, Vector2.zero, 0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Ext_Molecule")
        {
            Ext2Int.collider.transform.parent = DL_Holder;
            Ext2Int.collider.gameObject.transform.position = DL_Holder.position;
            Ext2Int.collider.gameObject.tag = "Int_Molecule";
        }
    }
}
//https://youtu.be/U8gUnpeaMbQ Snake
//https://youtu.be/1uq43EIzo-U Grab
//https://youtu.be/cIeWhztKyAg Asteroids
//https://answers.unity.com/questions/1455956/using-function-return-in-if-statement.html 
