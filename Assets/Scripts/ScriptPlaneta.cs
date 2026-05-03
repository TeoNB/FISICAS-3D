using System.Collections.Generic;
using UnityEngine;

public class ScriptPlaneta : MonoBehaviour
{
	public float gravedad = 50f;

	public List<Rigidbody> cuerpos = new List<Rigidbody>();

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate()
	{
		for (int i = 0; i < cuerpos.Count; i++)
		{
			Rigidbody cuerpo = cuerpos[i];

			if (cuerpo == null) continue;

			Vector3 direccion = transform.position - cuerpo.position;

			float distancia = direccion.magnitude;

			if (distancia == 0) continue;

			float fuerza = gravedad / (distancia * distancia);

			Vector3 fuerzaFinal = direccion.normalized * fuerza;

			cuerpo.AddForce(fuerzaFinal, ForceMode.Acceleration);
		}
	}
}
