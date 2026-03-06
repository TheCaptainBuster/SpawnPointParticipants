using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawnPosition;
    private GameObject player;

    private float timer;

    private void Start()
    { 
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance <= 8)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                enemyShoot();
            }
        }
    }

    void enemyShoot()
    {
        Instantiate(bullet, bulletSpawnPosition.position, Quaternion.identity);
    }
}
