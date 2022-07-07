using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string SceneName;

    public void ChangeS()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Quit()
    {
        Debug.Log("Jogo fechado.");
        Application.Quit();
    }
}
