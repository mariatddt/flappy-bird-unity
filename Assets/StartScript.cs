using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public AudioSource weird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startGame()
    {
        weird.Play();
        Invoke("LoadNextScene", weird.clip.length);
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
