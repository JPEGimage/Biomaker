using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class ActionObj : MonoBehaviour
{
    public GameObject GC, toco, player, hole, seed, gate;
    public GameObject ActionArea, Dialog;
    public string obj;
    private void Awake()
    {
        if (obj == "bird")
        {
            Kill();
        }
    }
    private void FixedUpdate()
    {
        if(obj == "bird")
        {
            transform.position += new Vector3(1.0f, 0f, 0f).normalized * (Time.deltaTime*10);
        }
    }
    public async void Kill()
    {
        await Task.Delay(25000);
        Destroy(gameObject);
    }
    public void TimeToAction()
    {
        switch (obj)
        {
            case "tree":
                if(player.GetComponent<Interaction>().desmatas)
                {
                    Instantiate(toco, gameObject.transform.position, gameObject.transform.rotation);
                    ActionArea.tag = "Stop";
                    Destroy(gameObject);
                }
                break;
            case "stump":
                ActionArea.tag = "Stop";
                Destroy(gameObject);
                break;
            case "plant":
                Instantiate(seed, gameObject.transform.position, gameObject.transform.rotation);
                ActionArea.tag = "Stop";
                Destroy(gameObject);
                break;
            case "button":
                Destroy(gate);
                Instantiate(toco, gameObject.transform.position, gameObject.transform.rotation);
                ActionArea.tag = "Stop";
                Destroy(gameObject);
                break;
            case "npc":
                Dialog.SetActive(true);
                break;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Action"))
        {
            Debug.Log("cacilda");
            TimeToAction();
        }
    }
}
