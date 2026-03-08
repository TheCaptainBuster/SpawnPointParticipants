using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar healthBarScript;
    public GameManager gameManager;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            gameManager.GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damageAmt)
    {
        currentHealth -= damageAmt;
        healthBarScript.SetPlayerHealth(currentHealth);
    }
}
