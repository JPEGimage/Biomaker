using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject actionButton;
    public GameObject axe;
    private bool inter = false;
    public string obj;

    public void Tree()
    {
        Debug.Log(obj);
    }
    void FixedUpdate()
    {
        if(inter)
        {
            actionButton.SetActive(true);
        }
        else
        {
            actionButton.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Tree"))
        {
            obj = "tree";
            inter = true;
        } 
        else if (coll.gameObject.CompareTag("Axe"))
        {
            obj = "axe";
            Destroy(axe);
            inter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        obj = "";
        inter = false;
    }
}
