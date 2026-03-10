using UnityEngine;

public class Objectives : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Balas>(out Balas b))
        {
            b.DestroyBullet();
            Destroy(this.gameObject);
        }
    }
}
