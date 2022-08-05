using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject actionButton, itemButton;
    public GameObject GC;
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
        //objects
        if(coll.gameObject.CompareTag("Tree"))
        {
            obj = "tree";
            inter = true;
        } 
        //items
        else if (coll.gameObject.CompareTag("Axe"))
        {
            obj = "axe";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Axe");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if(coll.gameObject.CompareTag("Glove"))
        { 
            obj = "glove";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Glove");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        obj = "";
        inter = false;
    }
}
