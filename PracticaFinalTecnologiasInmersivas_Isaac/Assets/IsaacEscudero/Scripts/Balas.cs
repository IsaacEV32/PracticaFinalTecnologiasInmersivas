using UnityEngine;
using System.Collections;
public class Balas : MonoBehaviour
{
    [SerializeField] float bulletLive;
    bool chronometerOn = false;
    private void Awake()
    {
        this.gameObject.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!chronometerOn)
        {
            bulletLive -= Time.deltaTime;
            StartCoroutine(TimeBullet());
        }
        if (bulletLive <= 0)
        {
            DestroyBullet();
        }
    }
    IEnumerator TimeBullet()
    {
        chronometerOn = true;
        yield return new WaitForSeconds(0.1f);
        chronometerOn = false;
    }
    public void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
