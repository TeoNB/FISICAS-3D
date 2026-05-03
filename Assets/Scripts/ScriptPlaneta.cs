using System.Collections.Generic;
using UnityEngine;

public class ScriptPlaneta : MonoBehaviour
{
	public float gravedad = 6673f;
	public GameObject Player;

	public Rigidbody player;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		player = Player.GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate()
	{
		if (player == null) return;

		Vector3 direccion = transform.position - player.position;

		float distancia = direccion.magnitude;

		if (distancia == 0) return;

		float fuerza = gravedad / (distancia * distancia);

		Vector3 fuerzaFinal = direccion.normalized * fuerza;

		player.AddForce(fuerzaFinal, ForceMode.Acceleration);
	}
}
