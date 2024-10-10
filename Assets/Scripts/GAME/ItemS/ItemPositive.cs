using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPositive : Item
{
    const float Positive_heal = 20;
    #region Unity Callbacks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            jetpack.AddEnergy(Positive_heal);
            Recolected() ;    

        }

        DestroyAfterTime();


    }
    #endregion

   
}
