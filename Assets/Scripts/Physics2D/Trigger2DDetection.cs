using UnityEngine;
using System;

public class Trigger2DDetection : MonoBehaviour
{    
    #region Properties
	#endregion

	#region Fields
	#endregion

	#region Unity Callbacks
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		//if (collision.gameObject.layer == 7)//Player enter in zone
		if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
			GetComponent<Animator>().SetBool("IsOpened", true);

	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
			GetComponent<Animator>().SetBool("IsOpened", false);

	}
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
