using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TransitionToNextLevel();
        }
    }

    private void TransitionToNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
