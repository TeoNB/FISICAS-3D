using UnityEngine;

public class ScriptBolos : MonoBehaviour
{
	public float force = 600f;
	public float rotationSpeed = 120f;
	public Transform startPoint;

	private Rigidbody rb;
	private Vector3 startPosition;
	private Quaternion startRotation;

	private bool hasLaunched = false;

	void Start()
	{
		rb = GetComponent<Rigidbody>();

		startPosition = startPoint.position;
		startRotation = startPoint.rotation;

		ResetBall();
	}

	void Update()
	{
		// Rotación antes de lanzar
		if (!hasLaunched)
		{
			float rotate = Input.GetAxis("Horizontal");
			transform.Rotate(Vector3.up * rotate * rotationSpeed * Time.deltaTime);

			if (Input.GetButtonDown("Jump"))
			{
				LaunchBall();
			}
		}

		// Reinicio automático
		if (transform.position.y < -5f)
		{
			ResetBall();
		}
	}

	void LaunchBall()
	{
		hasLaunched = true;
		rb.isKinematic = false;

		rb.AddForce(transform.forward * force, ForceMode.Impulse);
	}

	public void ResetBall()
	{
		hasLaunched = false;

		rb.linearVelocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;

		transform.position = startPosition;
		transform.rotation = startRotation;

		rb.isKinematic = true;
	}
}
