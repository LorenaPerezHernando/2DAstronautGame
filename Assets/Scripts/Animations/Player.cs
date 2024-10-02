using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {


        _anim.SetBool("Flying", _jetpack.Flying);
        
    }
}
