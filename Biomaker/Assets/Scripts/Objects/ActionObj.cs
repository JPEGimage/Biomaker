using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObj : MonoBehaviour
{
    public GameObject GC;
    public string obj;
    public void TimeToAction()
    {
        switch (obj)
        {
            case "tree":
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
