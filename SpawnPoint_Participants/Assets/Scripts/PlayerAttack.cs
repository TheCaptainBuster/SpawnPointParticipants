using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPrefab;

    public float bulletSpeed = 10f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
