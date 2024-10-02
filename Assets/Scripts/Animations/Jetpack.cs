using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jetpack : MonoBehaviour
{
    public enum Direction
    {
        Left, 
        Right
    }
    
    #region Properties
    public float Energy { get; set; }
    public bool Flying { get; set; }


    #endregion Properties

    #region Fields
    private Rigidbody2D _target;
    [SerializeField] private float _maxEnergy;
    [SerializeField] private float _EnergyFlyingRatio;
    [SerializeField] private float _horizontalForce;
    [SerializeField] private float _flyForce;
    [SerializeField] private float _energyRegerationRatio;

    #endregion Fields

    #region Unity Callbacks

    private void Awake()
    {
        _target = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Energy = _maxEnergy;
    }

    void FixedUpdate() //Pq le estamos añadiendo fuerzas 
    {
        if (Flying)
        {
            DoFly();
            
        }
    }

    #endregion Unity Callbacks

    #region Public Methods

    public void FlyUp()
    {
        Flying = true;
        DoFly();
    }
    public void StopFlying()
    {
        Flying = false;
    }
    public void Regenerate()
    {
        Energy += _energyRegerationRatio;
    }
    public void Regenerate (float energy)
    {
        Energy += energy; 
    }
    public void FlyHorizontal(Direction flyDirection)
    {

        if (!Flying) 
        {
            return; 
        }
        if (flyDirection == Direction.Left) 
        {
            _target.AddForce(Vector2.left * _horizontalForce);
        }
        else
        {
            _target.AddForce(Vector2.right * _horizontalForce);
        }
    }
    #endregion Public Methods

    private void DoFly()
    {
        if (Energy > 0)
        {
            _target.AddForce(Vector2.up * _flyForce);
            Energy -= _EnergyFlyingRatio;
        }
        else
            Flying = false; 
    }
}
