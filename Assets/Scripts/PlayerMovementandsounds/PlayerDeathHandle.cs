using System.Collections;  // <-- Add this line to fix the IEnumerator error
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    // Tag for the enemy objects
    [SerializeField] private string enemyTag = "Enemy";

    // Reference to the AudioManager instance
    private AudioManager audioManager;

    private void Awake()
    {
        // Ensure the AudioManager instance is set
        if (AudioManager.Instance != null)
        {
            audioManager = AudioManager.Instance; // Get the AudioManager instance
        }
        else
        {
            Debug.LogError("AudioManager instance is null. Please check if it's set in the scene.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collided with an object tagged as "Enemy"
        if (collision.gameObject.CompareTag(enemyTag))
        {
            Die();
        }
    }

    private void Die()
    {
        // Null check for AudioManager (if you still plan on using audio features)
        if (audioManager != null)
        {
            // Optional: You could still play a death sound here if needed, for example:
            // audioManager.PlaySound(deathSoundClip);
        }
        else
        {
            Debug.LogWarning("AudioManager is not set. No audio will play.");
        }

        // Immediately reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
