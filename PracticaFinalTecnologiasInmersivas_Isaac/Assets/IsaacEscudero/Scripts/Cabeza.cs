using UnityEngine;

public class Cabeza : MonoBehaviour
{
    [SerializeField] Rigidbody rbHead;
    [SerializeField] float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rbHead.AddTorque(transform.up * rotationSpeed, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            rbHead.AddTorque(-transform.up * rotationSpeed, ForceMode.Force);
        }
        else
        {
            rbHead.angularVelocity = Vector3.zero;
        }
    }
}
