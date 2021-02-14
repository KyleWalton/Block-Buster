using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystems : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GOMainMenu()
    {
        SceneManager.LoadScene((0));
    }

    public void QuitGame()
    {
        //Exit the game when not launched from inside the Unity Editor.
        Application.Quit();

        //For use inside Unity Engine
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
