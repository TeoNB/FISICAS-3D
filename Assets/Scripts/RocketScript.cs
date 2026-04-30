using UnityEngine;

public class RocketScript : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaDespegue = 600000f;
    bool despegueIniciado = false;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
			if (Input.GetKey(KeyCode.Space)){ 
			despegueIniciado = true; // Inicia el despegue cuando se presiona la barra espaciadora
		}
	}

	void FixedUpdate()
    {
		if (despegueIniciado)
		{
			rb.AddForce(Vector3.up * fuerzaDespegue, ForceMode.Force); // Aplica una fuerza hacia arriba para simular el despegue del cohete
		}
		
	}
}
