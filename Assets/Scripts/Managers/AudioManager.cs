using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Static instance of AudioManager
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
        // Initialize the instance if it hasn't been set
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // Keeps AudioManager between scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicates
        }

        // Get the AudioSource component
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

    // You can add other audio-related methods as needed
}


