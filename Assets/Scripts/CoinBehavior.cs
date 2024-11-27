using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public CircleCollider2D circelColl;

    private void Awake()
    {
        circelColl = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CoinsManager.Instance.IncreaseCoins();
        Destroy(gameObject);
    }
}
