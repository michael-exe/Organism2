using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentController : MonoBehaviour
{
    //ATTACH_CONTROLLER
    public Transform UR_Detector;
    public Transform UL_Detector;
    public Transform DR_Detector;
    public Transform DL_Detector;
    public Transform UR_Holder;
    public Transform UL_Holder;
    public Transform DR_Holder;
    public Transform DL_Holder;
    public GameObject Ext_Molecule;
    //private List<Transform> Int_Molecules;
    private List<Transform> Int_Molecules;
    //above should be private
    public Transform Int_MoleculePrefab;

    private void Start()
    {
        //ATTACH_CONTROLLER
        Int_Molecules = new List<Transform>();
        Int_Molecules.Add(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //ATTACH_CONTROLLER
        UR_Attach();
        UL_Attach();
        DR_Attach();
        DL_Attach();
    }

    //ATTACH_CONTROLLER
    private void UR_Attach()
    {
        RaycastHit2D attachCheck = Physics2D.Raycast(UR_Detector.position, Vector2.one * transform.localScale, 0);

        if (attachCheck.collider != null && attachCheck.collider.tag == "Ext_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = UR_Holder;
            //attachCheck.collider.gameObject.transform.position = UR_Holder.position;
            Destroy(attachCheck.collider.gameObject);
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = UR_Holder;
            Int_Molecule_Inst.transform.position = UR_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                attachCheck.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void UL_Attach()
    {
        RaycastHit2D attachCheck = Physics2D.Raycast(UL_Detector.position, Vector2.one * transform.localScale, -0);

        if (attachCheck.collider != null && attachCheck.collider.tag == "Ext_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = UL_Holder;
            //attachCheck.collider.gameObject.transform.position = UL_Holder.position;
            //Destroy(Ext_Molecule);
            Destroy(attachCheck.collider.gameObject);
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = UL_Holder;
            Int_Molecule_Inst.transform.position = UL_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                attachCheck.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void DR_Attach()
    {
        RaycastHit2D attachCheck = Physics2D.Raycast(DR_Detector.position, Vector2.one * transform.localScale, 0);

        if (attachCheck.collider != null && attachCheck.collider.tag == "Ext_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = DR_Holder;
            //attachCheck.collider.gameObject.transform.position = DR_Holder.position;
            //Destroy(Ext_Molecule);
            //Destroy(GameObject.FindWithTag("Ext_Molecule"));
            Destroy(attachCheck.collider.gameObject);
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = DR_Holder;
            Int_Molecule_Inst.transform.position = DR_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                attachCheck.collider.gameObject.transform.parent = null;
            }
        }
    }
    private void DL_Attach()
    {
        RaycastHit2D attachCheck = Physics2D.Raycast(DL_Detector.position, Vector2.one * transform.localScale, -0);

        if (attachCheck.collider != null && attachCheck.collider.tag == "Ext_Molecule")
        {
            //attachCheck.collider.gameObject.transform.parent = DL_Holder;
            //attachCheck.collider.gameObject.transform.position = DL_Holder.position;
            //Destroy(Ext_Molecule);
            Destroy(attachCheck.collider.gameObject);
            Transform Int_Molecule_Inst = Instantiate(this.Int_MoleculePrefab);
            Int_Molecule_Inst.transform.parent = DL_Holder;
            Int_Molecule_Inst.transform.position = DL_Holder.position;

            if (Input.GetKey(KeyCode.X))
            {
                attachCheck.collider.gameObject.transform.parent = null;
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
