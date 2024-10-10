using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //Script en el collider de la plataforma final (Sol) 
    //Indica el final del juego y el principio de uno nuevo al pulsar el boton Play Again
    [SerializeField] private GameObject panelFinal;
    [SerializeField] GameObject player;
    [SerializeField] private UIController _UIcontroller;
    [SerializeField] GameObject[] checkpoints;

    private void Start()
    {
        panelFinal.SetActive(false);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.GetComponent<InputController>().InGame = false;
            panelFinal.SetActive(true);
            _UIcontroller.SustituirStats();
        }
    }

    public void PlayAgain()
    {
        player.GetComponent<InputController>().InGame = true;
        panelFinal.SetActive(false);
        player.transform.position = new Vector3(0.3f, 10, 0);
        _UIcontroller.StatsDeJuego();
        
        
    }
}
