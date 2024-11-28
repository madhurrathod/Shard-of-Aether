using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip soundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySound(soundEffect);
        }
    }
}
