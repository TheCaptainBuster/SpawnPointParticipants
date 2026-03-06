using System.Runtime.Serialization;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject playerBullet;
    public float TotalHealth=5f;
    private float currentHealth;

    public GameObject coinPrefab;
    public Transform coinSpawnPosition;
    private void Start()
    {
        currentHealth = TotalHealth;
        //coinPrefab = GameObject.FindGameObjectWithTag("Coin");
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            Instantiate(coinPrefab, coinSpawnPosition.position, Quaternion.identity);
            currentHealth = 0;
            Destroy(this.gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            currentHealth -= 1;
        }
    }
}
