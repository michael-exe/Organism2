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
    public GameObject Ext_Molecule;
    private List<Transform> Int_Molecules;
    public Transform Int_MoleculePrefab;
    private Collision other;

    private void Start()
    {
        //HOLDER(int)
        Int_Molecules = new List<Transform>();
        Int_Molecules.Add(this.transform);
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
    private void UR_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(UR_Detector.position, Vector2.one * transform.localScale, 0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Int_Molecule")
        {

            Destroy(Ext_Molecule);
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = UR_Holder;
            Int_Molecule_Inst.transform.position = UR_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                Ext2Int.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void UL_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(UL_Detector.position, Vector2.one * transform.localScale, -0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Int_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = UL_Holder;
            //attachCheck.collider.gameObject.transform.position = UL_Holder.position;
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = UL_Holder;
            Int_Molecule_Inst.transform.position = UL_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                Ext2Int.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void DR_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(DR_Detector.position, Vector2.one * transform.localScale, 0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Int_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = DR_Holder;
            //attachCheck.collider.gameObject.transform.position = DR_Holder.position;
            //Destroy(Ext_Molecule);

            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = DR_Holder;
            Int_Molecule_Inst.transform.position = DR_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                Ext2Int.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void DL_Attach()
    {
        RaycastHit2D Ext2Int = Physics2D.Raycast(DL_Detector.position, Vector2.one * transform.localScale, -0);

        if (Ext2Int.collider != null && Ext2Int.collider.tag == "Int_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = DL_Holder;
            //attachCheck.collider.gameObject.transform.position = DL_Holder.position;

            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = DL_Holder;
            Int_Molecule_Inst.transform.position = DL_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                Ext2Int.collider.gameObject.transform.parent = null;
            }
        }
    }

 
    private void AttachersInstantiation()
    {
        //Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
        //Int_Molecule_Inst.position = UR_Holder.position;
        ////Int_Molecule_Inst.position = Int_Molecules[Int_Molecules.Count - 1].position;
        //Int_Molecules.Add(Int_Molecule_Inst);
    }
    //https://youtu.be/U8gUnpeaMbQ Snake
    //https://youtu.be/1uq43EIzo-U Grab
    //https://youtu.be/cIeWhztKyAg Asteroids
}
