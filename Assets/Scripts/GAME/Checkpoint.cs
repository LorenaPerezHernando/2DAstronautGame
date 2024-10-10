using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //Script en las plataformas de cada nivel (iniciado, junior, gamedev)
    //Trigger cuando pasas y sin trigger para que te paren la caida
    Collider2D _collider;
    [SerializeField] ItemSpawner _spawner;
    [SerializeField] InputController _inputController;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _collider.isTrigger = true;
    }

    private void Update()
    {
        if(_inputController.InGame == false)
        {
            RestartTrigger();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")   
        {
            _collider.isTrigger = false;
            gameObject.tag = "Ground";
        }              
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            Vector3 playerPos = collision.transform.position;
            Vector3 thisPos = transform.position;

            if (playerPos.y < thisPos.y)
                _collider.isTrigger = true;
        }
    }

    public void RestartTrigger()
    {
        _collider.isTrigger = true;
    }


}
