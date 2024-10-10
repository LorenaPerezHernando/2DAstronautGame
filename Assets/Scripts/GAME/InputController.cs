using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    //Script en el player para su movimiento y el bool de inicio de juego
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Jetpack _jetpack;
    [SerializeField] public bool InGame;
    #endregion
    void Start()
    {
        InGame = true; 
    }

    void Update()
    {
        if(InGame == true)
        {
            if (Input.GetAxis("Horizontal") < 0)
                _jetpack.FlyHorizontal(Jetpack.Direction.Left);
            if(Input.GetAxis("Horizontal") > 0)
                _jetpack.FlyHorizontal(Jetpack.Direction.Right);

            if(Input.GetAxis("Vertical") > 0)
            {
                _jetpack.FlyUp(); 
            }
            else
                _jetpack.StopFlying();

        }

        

    }
}
