using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound; // Assign the coin sound in the Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the coin collection sound
            AudioManager.Instance.PlaySound(coinSound);

            // Handle other coin collection logic (e.g., increment score)
            CollectCoin();
        }
    }

    void CollectCoin()
    {
        // Example: Add to the score
        Debug.Log("Coin Collected!");

        // Destroy the coin after collection
        Destroy(gameObject);
    }
}

