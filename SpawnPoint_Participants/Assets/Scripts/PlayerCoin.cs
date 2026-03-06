using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCoin : MonoBehaviour
{
    private int coinCount = 0;

    public TextMeshProUGUI coinCountText;

    private void Start()
    {
        coinCountText.text = "0";
    }
    private void Update()
    {
        /*if(coinScript.coinCollected == true)
        {
            coinCount += 1;
            Debug.Log(coinCount);
            coinCountText.text = coinCount.ToString(); 
        }*/
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
