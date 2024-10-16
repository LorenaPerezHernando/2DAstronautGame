using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour, IRecolectable
{
    #region Contants
    const float NoSe_Damage = 20;
    const float Error_Force = 5000;
    const float Error_Down = 2.5f;
    const float Positive_heal = 20; 
    #endregion

    #region Enums

    public enum ItemTypes
    {
        None,
        NoSe,
        ErrorCode,
        PositiveWords
    }
    #endregion
    #region Properties

    
    [field: SerializeField] public ItemTypes Type { get; set; }
    #endregion

    #region Fields
    [SerializeField] private GameObject _particles; 
    #endregion

    #region Callbacks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
            Destroy(gameObject);
        if(collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            switch (Type)
            {
                case ItemTypes.ErrorCode:
                    if (jetpack.Flying)
                        jetpack.GetComponent<Rigidbody2D>().AddForce(Vector2.down * Error_Force);
                    else
                        jetpack.transform.Translate(Vector2.down * Error_Down);
                    break;

                case ItemTypes.NoSe:
                    jetpack.AddEnergy(NoSe_Damage);
                    break;

                case ItemTypes.PositiveWords:
                    jetpack.AddEnergy(Positive_heal);
                    break;

            }
            
        }
    }

    #endregion

    #region Public Methods
    public void Recolected()
    {
        CreateParticles();
        Destroy(gameObject);
    }

    #endregion
    private void CreateParticles()
    {
        Instantiate(_particles, transform.position, Quaternion.identity);
    }

    public IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
