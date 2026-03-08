using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCoin : MonoBehaviour
{
    private int coinCount = 0;
    public GameManager gameManager;

    public TextMeshProUGUI coinCountText;

    private void Start()
    {
        coinCountText.text = "0";
    }
    private void Update()
    {
        if (coinCount == 5)
        {
            gameManager.GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coinCount += 1;
            coinCountText.text = coinCount.ToString();
        }
    }
}
