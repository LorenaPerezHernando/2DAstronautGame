using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNose : Item
{
    const float NoSe_Damage = 20;
    #region Unity Callbacks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            Recolected();
        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            jetpack.AddEnergy(NoSe_Damage);
            Recolected() ;

        }
    }
    #endregion
}
