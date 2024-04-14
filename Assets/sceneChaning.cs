using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName; // Name of the scene to load
    public KeyCode changeSceneKey; // Key to trigger scene change

    void Update()
    {
        // Check if the specified key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Load the specified scene
            SceneManager.LoadScene("Track");
        }
    }
}
