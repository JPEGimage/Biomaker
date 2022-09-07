using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
public class Interaction : MonoBehaviour
{
    public GameObject actionButton, itemButton;
    public GameObject GC, ActionArea, GO, GW;
    public GameObject hole, player, playercave;
    public GameObject alert,NewD;
    public Slider prog;
    public bool inter = false, cavante = false, desmatas = false, final = false;
    public string obj,item = "";
    public int plant = 3, score = 0;

    public AudioSource cut;
    public AudioSource cave;
    public AudioSource ale;
    public AudioSource stump;

    public AudioSource won;
    public AudioSource lose;
    public void Tree()
    {
        Debug.Log(obj);
        switch(item)
        {
            case "axe":
                Debug.Log("quebrando " + obj);
                if(obj == "tree")
                {
                    desmatas = true;
                    ActionArea.tag = "Action";
                    plant -= 1;
                    Action();
                    NoAction();
                    cut.Play();
                }
                //essencial
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else if (obj == "jpeg")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else
                {
                    alert.SetActive(true);
                    Action();
                    NoAction();
                    ale.Play();
                }
                break;
            case "glove":
                Debug.Log("tirando " + obj);
                if (obj == "stump")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    stump.Play();
                }
                //essencial
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else if (obj == "jpeg")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else
                {
                    alert.SetActive(true);
                    Action();
                    NoAction();
                    ale.Play();
                }
                break;
            case "shovel":
                Debug.Log("cavando");
                if (obj != "plant" && obj != "button" && obj != "jpeg" && obj != "pont")
                {
                    Instantiate(hole, playercave.transform.position, player.transform.rotation);
                    ActionArea.tag = "Stop";
                    cave.Play();
                }
                //essencial
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else if (obj == "jpeg")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else
                {
                    alert.SetActive(true);
                    Action();
                    NoAction();
                    ale.Play();
                }
                break;
            case "seed":
                Debug.Log("plantando");
                if (obj == "plant")
                {
                    ActionArea.tag = "Action";
                    score += 1;
                    Action();
                    NoAction();
                    stump.Play();
                }
                //essencial
                else if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else if (obj == "jpeg")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else
                {
                    alert.SetActive(true);
                    Action();
                    NoAction();
                    ale.Play();
                }
                break;
            default:
                 //essencial
                if (obj == "button")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else if (obj == "jpeg")
                {
                    ActionArea.tag = "Action";
                    Action();
                    NoAction();
                    ale.Play();
                }
                else
                {
                    alert.SetActive(true);
                    Action();
                    NoAction();
                    ale.Play();
                }
                break;
        }
    }
    public async void Action()
    {
        await Task.Delay(30);
        desmatas = false;
        ActionArea.tag = "Stop";
    }
    public async void NoAction()
    {
        await Task.Delay(2000);
        alert.SetActive(false);
        NewD.SetActive(false);
    }
    void FixedUpdate()
    {
        //win and lose
        prog.value = score;

        if (plant <= 0 && final == false)
        {
            GO.SetActive(true);
            lose.Play();
            final = true;
        }
        else if (score >= 5 && final == false)
        {
            GW.SetActive(true);
            won.Play();
            final = true;
        }
        //inter
        if (inter)
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
        else if (coll.gameObject.CompareTag("JPEG"))
        {
            obj = "jpeg";
            inter = true;
        }
        else if (coll.gameObject.CompareTag("pont"))
        {
            obj = "pont";
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
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if(coll.gameObject.CompareTag("Glove"))
        { 
            obj = "glove";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Glove");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Seed"))
        {
            obj = "seed";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Seed");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Torch"))
        {
            obj = "torch";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Torch");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Shovel"))
        {
            obj = "shovel";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Shovel");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Rod"))
        {
            obj = "rod";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Rod");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Bucket"))
        {
            obj = "bucket";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Bucket");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Poison"))
        {
            obj = "poison";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Poison");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("Hoe"))
        {
            obj = "hoe";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Hoe");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("gBait"))
        {
            obj = "gBait";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("gBait");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
        }
        else if (coll.gameObject.CompareTag("rBait"))
        {
            obj = "rBait";
            GC.GetComponent<Inventory>().Valid();
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("rBait");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);
            //alert
            NewD.SetActive(true);
            NoAction();
            ale.Play();
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
