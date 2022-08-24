using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class Interaction : MonoBehaviour
{
    public GameObject actionButton, itemButton;
    public GameObject GC, ActionArea;
    public GameObject hole, player, playercave;
    public bool inter = false, cavante = false;
    public string obj,item = "";

    public void Tree()
    {
        Debug.Log(obj);
        switch(item)
        {
            case "axe":
                Debug.Log("quebrando " + obj);
                if(obj == "tree")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                break;
            case "glove":
                Debug.Log("tirando " + obj);
                if (obj == "stump")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                break;
            case "shovel":
                Debug.Log("cavando");
                if (obj != "plant")
                {
                    Instantiate(hole, playercave.transform.position, player.transform.rotation);
                    ActionArea.tag = "Stop";
                }
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                break;
            case "seed":
                Debug.Log("plantando");
                if (obj == "plant")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                else if(obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                }
                break;
            default:
                break;
        }
    }
    public async void Action()
    {
        await Task.Delay(30);
        ActionArea.tag = "Stop";
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
        else if (coll.gameObject.CompareTag("Stump"))
        {
            obj = "stump";
            inter = true;
        }
        else if (coll.gameObject.CompareTag("Plantzone"))
        {
            obj = "cave";
            inter = true;
        }
        else if (coll.gameObject.CompareTag("Hole"))
        {
            obj = "plant";
            inter = true;
        }
        else if (coll.gameObject.CompareTag("Button"))
        {
            obj = "button";
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
        else if (coll.gameObject.CompareTag("Seed"))
        {
            obj = "seed";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Seed");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Torch"))
        {
            obj = "torch";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Torch");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Shovel"))
        {
            obj = "shovel";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Shovel");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Rod"))
        {
            obj = "rod";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Rod");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Bucket"))
        {
            obj = "bucket";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Bucket");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Poison"))
        {
            obj = "poison";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Poison");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("Hoe"))
        {
            obj = "hoe";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Hoe");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("gBait"))
        {
            obj = "gBait";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("gBait");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
        else if (coll.gameObject.CompareTag("rBait"))
        {
            obj = "rBait";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("rBait");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if(cavante == false)
        {
            inter = false;
        }
        obj = "";
    }
}
