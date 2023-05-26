using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathbox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Reagan player = collision.gameObject.GetComponent<Reagan>();
            if (player != null)
            {
                player.Die();
                ReloadScene();
            }
        }
    }

    private void ReloadScene()
    {
        // Get the current scene's index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}

