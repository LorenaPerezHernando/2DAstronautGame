using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameController : MonoBehaviour
{
    //Script en Objeto un GameController para Salir
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
    }

    public void buttonExit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
