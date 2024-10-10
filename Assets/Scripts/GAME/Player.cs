using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    //Script en Player, animacion de su sprite
    #region Properties

    #endregion

    #region Fields
    [SerializeField] private Jetpack _jetpack;
    private Animator _anim;
    #endregion

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        _anim.SetBool("Flying", _jetpack.Flying);      
    }
}
