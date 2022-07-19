using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ChangeS(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void VizualizeTrue(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void VizualizeFalse(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Jogo fechado.");
        Application.Quit();
    }
    public void Oi(string o)
    {
        Debug.Log(o);
    }
}
