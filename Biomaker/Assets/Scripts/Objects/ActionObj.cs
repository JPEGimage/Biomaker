using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObj : MonoBehaviour
{
    public GameObject GC, toco, player, hole, seed, gate;
    public GameObject ActionArea;
    public string obj;
    public void TimeToAction()
    {
        switch (obj)
        {
            case "tree":
                Instantiate(toco, gameObject.transform.position, gameObject.transform.rotation);
                ActionArea.tag = "Stop";
                Destroy(gameObject);
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
