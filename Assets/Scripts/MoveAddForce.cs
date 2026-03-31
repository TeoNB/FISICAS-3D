using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAddForce : MonoBehaviour
{
	public float force = 10f;
	private Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if (Keyboard.current != null && Keyboard.current.wKey.wasPressedThisFrame)
		{
			Debug.Log("avanza");
			rb.AddForce(transform.forward * force, ForceMode.Force);
		}
	}
}
