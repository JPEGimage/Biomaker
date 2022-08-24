using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public bool I = false;
    public Image itemButton;
    public GameObject GC;
    public GameObject inv, Int;
    public GameObject axe, glove, seed, torch, shovel, rod, bucket, poison, hoe, gBait, rBait;

    private void Start()
    {
        inv.SetActive(false);

        axe.SetActive(false);
        glove.SetActive(false);
        seed.SetActive(false);
        torch.SetActive(false);
        shovel.SetActive(false);
        rod.SetActive(false);
        bucket.SetActive(false);
        poison.SetActive(false);
        hoe.SetActive(false);
        gBait.SetActive(false);
        rBait.SetActive(false);
    }

    public void Valid()
    {
        if (Int.GetComponent<Interaction>().obj == "axe")
        {
            axe.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "glove")
        {
            glove.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "seed")
        {
            seed.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "torch")
        {
            torch.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "shovel")
        {
            shovel.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "rod")
        {
            rod.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "bucket")
        {
            bucket.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "poison")
        {
            poison.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "hoe")
        {
            hoe.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "gBait")
        {
            gBait.SetActive(true);
        }
        if (Int.GetComponent<Interaction>().obj == "rBait")
        {
            rBait.SetActive(true);
        }
    }

    public void Select(Sprite s)
    {
        itemButton.sprite = s;
        Int.GetComponent<Interaction>().item = s.name;
        if(s.name == "shovel")
        {
            Int.GetComponent<Interaction>().cavante = true;
            Int.GetComponent<Interaction>().inter = true;
        }
        else
        {
            Int.GetComponent<Interaction>().cavante = false;
            Int.GetComponent<Interaction>().inter = false;
        }
        inv.SetActive(false);
    }
}
