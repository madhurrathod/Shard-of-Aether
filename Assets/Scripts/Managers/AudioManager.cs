using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Static instance to easily access the AudioManager
    private static AudioManager _instance;

    // Public property to access the instance
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("AudioManager instance is not set!");
            }
            return _instance;
        }
    }

    // Reference to the AudioSource component
    private AudioSource audioSource;

    private void Awake()
    {
        // If an instance already exists, destroy this one
        if (_instance == null)
        {
            _instance = this;
            // Remove DontDestroyOnLoad as you don't need the AudioManager to persist across scenes
            // DontDestroyOnLoad(gameObject); // This is removed now
        }
        else
        {
            Destroy(gameObject); // Destroy this instance if one already exists
        }

        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // Play a sound effect
    public void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip is missing.");
        }
    }

    // You can add other audio-related methods as needed, e.g., adjusting volume, looping, etc.
}


