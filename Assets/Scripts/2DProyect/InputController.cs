using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Jetpack _jetpack;
    #endregion
    void Start()
    {
        
    }

    void Update()
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
