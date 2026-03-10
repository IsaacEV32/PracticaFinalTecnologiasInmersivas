using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    [SerializeField] Rigidbody rbBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            rbBody.AddTorque(new Vector3(0, horizontal * rotationSpeed, 0), ForceMode.Force);
            rbBody.AddForce( transform.forward * vertical * speed, ForceMode.Force);
        }
        else 
        {
            rbBody.linearVelocity = Vector3.zero;
            rbBody.angularVelocity = Vector3.zero;
        }
    }
}
