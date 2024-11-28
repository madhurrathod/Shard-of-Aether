using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; } // Singleton instance
    private AudioSource audioSource;

    void Awake()
    {
        // Ensure only one instance exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: keep the audio manager across scenes
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
    public void StopAllSounds()
    {
            audioSource.Stop();
    }
    
}

