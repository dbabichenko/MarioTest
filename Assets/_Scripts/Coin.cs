using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log($"Coin triggered by {other.name}");
        if (other.CompareTag("Player"))
        {
            // Debug.Log("Coin collected!");
            GameManager.Instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}
