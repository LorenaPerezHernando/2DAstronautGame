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
		if (Input.GetKeyDown(KeyCode.RightArrow))
			_animator.SetBool("Run", true);

		if (Input.GetKeyUp(KeyCode.RightArrow))
			_animator.SetBool("Run", false);

		if (Input.GetKeyDown(KeyCode.Mouse0))
			_animator.SetTrigger("Attack");

		if (Input.GetKeyDown(KeyCode.Space))
			_animator.SetTrigger("Jump");
	}
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
