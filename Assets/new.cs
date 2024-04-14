using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // Public method to be assigned to the button's OnClick event in the Unity Editor
    public void OnButtonClick()
    {
        // Load the scene with the specified name
        SceneManager.LoadScene("Scenes/track");
    }
}
