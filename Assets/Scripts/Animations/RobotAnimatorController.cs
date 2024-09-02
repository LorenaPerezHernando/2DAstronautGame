using UnityEngine;
using System;

public class RobotAnimatorController : MonoBehaviour
{    
    #region Properties
	#endregion

	#region Fields
	[SerializeField] private Animator _animator;
	#endregion

	#region Unity Callbacks
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Set Animator properties state
		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
			_animator.SetBool("Run", true);

		if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
			_animator.SetBool("Run", false);



		if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
			_animator.SetBool("Down", true); 

		if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
			_animator.SetBool("Down", false) ;



		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
			_animator.SetBool("Dash", true);

		if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
			_animator.SetBool("Dash", false);



		if (Input.GetKeyDown(KeyCode.E))
			_animator.SetTrigger("tp");



        if (Input.GetKeyDown(KeyCode.Mouse0))
			_animator.SetTrigger("Attack");



		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
			_animator.SetTrigger("Jump");
	}
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
