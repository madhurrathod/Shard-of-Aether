using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove_Ref : MonoBehaviour
{
    public int sceneBuildIndex; // Index of the scene to load

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if (other.CompareTag("Player"))
        {
            print("Switching Scene to " + sceneBuildIndex + " in 2 seconds...");
            StartCoroutine(SwitchSceneWithDelay());
        }
    }

    private IEnumerator SwitchSceneWithDelay()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single); // Load the scene
    }
}

