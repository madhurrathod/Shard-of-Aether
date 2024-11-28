using System.Collections;  // <-- Add this line to fix the IEnumerator error
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    // Tag for the enemy objects
    [SerializeField] private string enemyTag = "Enemy";

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
        // Immediately reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}



