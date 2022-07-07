using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BiomeSelector : MonoBehaviour
{
    public GameObject panel;
    public Text t;
    Image p;
    public string select;
    void Start()
    {
        p = panel.GetComponent<Image> ();
        select = "Amazônia";
        p.color = Color.green;
        t.text = select;
    }
 
    public void AlterBiome(string bio)
    {
        switch (bio)
        {
            case "amazonia":
                Debug.Log("escolheu amazonia");
                select = "Amazônia";
                p.color = Color.green;
                t.text = select;
                break;

            case "caatinga":
                Debug.Log("escolheu caatinga");
                select = "Caatinga";
                p.color = new Color(1.0f, 0.64f, 0.0f);
                t.text = select;
                break;

            case "cerrado":
                Debug.Log("escolheu cerrado");
                select = "Cerrado";
                p.color = Color.red;
                t.text = select;
                break;

            case "pantanal":
                Debug.Log("escolheu pantanal");
                select = "Pantanal";
                p.color = Color.cyan;
                t.text = select;
                break;

            case "mata":
                Debug.Log("escolheu mata atlântica");
                select = "Mata Atlântica";
                p.color = Color.blue;
                t.text = select;
                break;

            case "pampa":
                Debug.Log("escolheu pampa");
                select = "Pampa";
                p.color = Color.yellow;
                t.text = select;
                break;
            default:

            break;
        }
    }
    public void EnterLvl(int lvl)
    {
        switch (select)
        {
            case "Amazônia":
                if(lvl == 1)
                {
                    SceneManager.LoadScene("TestLevel");
                }
                else if(lvl == 2)
                {

                }
                else
                {

                }
                break;

            case "Caatinga":

                break;

            case "Cerrado":

                break;

            case "Pantanal":

                break;

            case "Mata Atlântica":

                break;

            case "Pampa":

                break;
            default:

                break;
        }
    }
}
