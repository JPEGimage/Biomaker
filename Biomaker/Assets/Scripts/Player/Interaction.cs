using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject actionButton;
    private bool inter = false;
    public string obj;

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
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        obj = "";
        inter = false;
    }
}
