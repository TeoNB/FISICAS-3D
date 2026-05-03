using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
	public Transform planeta;
	private Rigidbody rb;

	public float speed = 10f;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;

	}

	// Update is called once per frame
	void FixedUpdate()
    {
		
		Vector3 direccionGravedad = (planeta.position - transform.position).normalized;
		
		Quaternion rotacionObjetivo = Quaternion.FromToRotation(transform.up, -direccionGravedad) * transform.rotation;
		rb.rotation = Quaternion.Slerp(rb.rotation, rotacionObjetivo, 10f * Time.fixedDeltaTime);

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 movimiento = transform.forward * vertical + transform.right * horizontal;

		rb.AddForce(movimiento * speed, ForceMode.Acceleration);
	}
}
