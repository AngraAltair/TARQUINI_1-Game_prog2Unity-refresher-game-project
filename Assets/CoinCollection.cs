using TMPro;
using UnityEngine;


public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "coin")
        {
            Coin++;
            coinText.text = "Coin= " +Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
}
