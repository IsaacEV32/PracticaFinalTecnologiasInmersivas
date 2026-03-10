
using Unity.VisualScripting;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform puntoDeMira;
    [SerializeField] float bulletSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet, puntoDeMira.position, Quaternion.identity);
            b.GetComponent<Rigidbody>().AddForce(puntoDeMira.transform.forward * bulletSpeed, ForceMode.Impulse);
        }
       
    }
}
