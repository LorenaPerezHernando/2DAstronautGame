using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("FIN; ENHORABUENA     //AÑADIR TEXTO Y PARAR JUEGO Y PANEL DE LAS ESTADISTICAS");
        }
    }
}
