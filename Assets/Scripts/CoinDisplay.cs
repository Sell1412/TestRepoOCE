using TMPro;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    TextMeshProUGUI coinText;

    private void Awake()
    {
        coinText = GetComponent<TextMeshProUGUI>();
    }

    public void SetCoins(int coins)
    {
        UpdateText(coins);
    }

    private void UpdateText(int currentCoins)
    {
        coinText.text = $"Coins: {currentCoins}";
    }
}
