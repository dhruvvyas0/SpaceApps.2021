using UnityEngine;

public class ShipControls : MonoBehaviour
{
    public float force;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * force * Time.deltaTime;
        rb.AddForce(x, 0.0f, 0.0f);
    }
}