using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemError : Item
{
    const float Error_Force = 5000;
    const float Error_Down = 2.5f;
    #region Unity CallBacks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Recolected();
        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            if (jetpack.Flying)
               jetpack.GetComponent<Rigidbody2D>().AddForce(Vector2.down * Error_Force);
            else
                if(jetpack.transform.position.y > 1) //Para evitar que nos unda en el suelo 
               jetpack.transform.Translate(Vector2.down * Error_Down);
            Recolected();
                              
        }
    }
    #endregion


}
