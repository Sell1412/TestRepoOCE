using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinsManager : MonoBehaviour
{
    public CoinDisplay coinDisplay;
    public int CurrentCoins { get; set; }

    public static CoinsManager Instance;

    private void Awake()
    {
        //Singeln Pattern
        if (Instance == null) 
        { 
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else Destroy(this);
    }

    private void Start()
    {
        coinDisplay.SetCoins(CurrentCoins);
    }
    public void IncreaseCoins()
    {
        CurrentCoins++;

        coinDisplay.SetCoins(CurrentCoins);
    }
}
