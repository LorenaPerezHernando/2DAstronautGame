using UnityEngine;
using System;

public class RobotAnimatorController : MonoBehaviour
{
	#region Properties
	public SpriteRenderer punch;
	#endregion

	#region Fields
	[SerializeField] private Animator _animator;
	private SpriteRenderer _spriteRenderer;
	bool _izquierda = false;
	#endregion

	#region Unity Callbacks
	// Start is called before the first frame update
	void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
		//punch = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
		if (_izquierda) _spriteRenderer.flipX = true; 

		//Set Animator properties state
		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
		{ 
			_animator.SetBool("Run", true);
		    _spriteRenderer.flipX = false;
			_izquierda = false; 
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
		{ 
            _animator.SetBool("Run", true);
		    _spriteRenderer.flipX = true;
			_izquierda = true;
        }
  
		if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
			_animator.SetBool("Run", false);
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            _animator.SetBool("Run", false);





        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
		{

			_animator.SetBool("Down", true);
			Izquierda();
		}	
		if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
			_animator.SetBool("Down", false) ;



		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
		{
			_animator.SetBool("Dash", true);
			Izquierda();
		}
		if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
			_animator.SetBool("Dash", false);



		if (Input.GetKeyDown(KeyCode.E))
			_animator.SetTrigger("tp");



        if (Input.GetKeyDown(KeyCode.Mouse0) && _izquierda == false)
		{
			_animator.SetTrigger("Attack");
		}
		else if (Input.GetKeyDown(KeyCode.Mouse0) && _izquierda == true)
		{
			_animator.SetTrigger("AttackIzq"); 
		}



		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
			_animator.SetTrigger("Jump");
	}
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods

	void Izquierda()
	{
		if(_izquierda == false)
			_spriteRenderer.flipX = false;

		else _spriteRenderer.flipX = true;
	}
	#endregion
}
