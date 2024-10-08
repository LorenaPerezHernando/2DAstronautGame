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
    public float Energy {
        get
        {
            return _energy;
        }
        set
        {
            _energy = Mathf.Clamp(value, 0, _maxEnergy);
        }
    }
    public bool Flying { get; set; }


    #endregion Properties

    #region Fields
    private Rigidbody2D _targetRB;
    [SerializeField] private float _energy;
    [SerializeField] private float _maxEnergy;
    [SerializeField] private float _EnergyFlyingRatio;
    [SerializeField] private float _horizontalForce;
    [SerializeField] private float _flyForce;
    [SerializeField] private float _energyRegerationRatio;

    private SpriteRenderer _sprite;

    #endregion Fields

    #region Unity Callbacks

    private void Awake()
    {
        _targetRB = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
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

        //El valor absoluto le quitamos el signo a la velocidad si es negativa
        //Si es menor que 0.1, consideramos que estamos parados y cargamos
        if(Mathf.Abs(_targetRB.velocity.y) < 0.1f)
            Regenerate();
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
    public void AddEnergy (float energy)
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
            _targetRB.AddForce(Vector2.left * _horizontalForce);
            _sprite.flipX = false; 
        }
        else
        {
            _targetRB.AddForce(Vector2.right * _horizontalForce);
            _sprite.flipX = true; 
        }
    }
    #endregion Public Methods

    private void DoFly()
    {
        if (Energy > 0)
        {
            _targetRB.AddForce(Vector2.up * _flyForce);
            Energy -= _EnergyFlyingRatio;
        }
        else
            Flying = false; 
    }
}
