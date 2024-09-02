using UnityEngine;
using System;

public class SwordDetection2D : MonoBehaviour
{
	#region Properties
	#endregion

	#region Fields
	[SerializeField] private float froceBase = 100;
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
		//Preguntar si un objeto tiene puesto un componente
		if(collision.GetComponent<Rigidbody2D>() != null)
		{
			//Destino menos origen nos da el vector dirección
			Vector2 forceDirection = collision.transform.position - transform.position; //Objeto position - espada position
			float distance = (2 - Vector2.Distance(collision.transform.position, transform.position));
			collision.GetComponent<Rigidbody2D>().AddForce(forceDirection * distance * froceBase);
		}

	}
	#endregion

	#region Public Methods
	#endregion

	#region Private Methods
	#endregion
}
