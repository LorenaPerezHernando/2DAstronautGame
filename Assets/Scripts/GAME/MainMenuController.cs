using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //Script de la escena Main Menu
    [SerializeField] Button _startGameButton;
    [SerializeField] Button _exitGameButton;

    private void Start()
    {
        _startGameButton.onClick.AddListener(StartGame);
        _exitGameButton.onClick.AddListener(EndGame);
    }

    private void EndGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Practica2D");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
