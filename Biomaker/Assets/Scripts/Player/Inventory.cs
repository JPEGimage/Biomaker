using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public bool I = false;
    public Image itemButton;
    public GameObject Int, inv;
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
    }

    public void Select(Sprite s)
    {
        itemButton.sprite = s;
        inv.SetActive(false);
    }
}
