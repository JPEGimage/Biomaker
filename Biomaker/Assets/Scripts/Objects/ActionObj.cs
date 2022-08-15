using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObj : MonoBehaviour
{
    public GameObject GC, toco, player, hole, seed;
    public string obj;
    public void TimeToAction()
    {
        switch (obj)
        {
            case "tree":
                Instantiate(toco, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);
                break;
            case "stump":
                Destroy(gameObject);
                break;
            case "plant":
                Instantiate(hole, player.transform.position, player.transform.rotation);
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
