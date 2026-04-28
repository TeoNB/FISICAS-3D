using UnityEngine;

public class RocketScript : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaDespegue = 60000f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.up * fuerzaDespegue); // Aplica una fuerza hacia arriba para simular el despegue del cohete
	}
}
