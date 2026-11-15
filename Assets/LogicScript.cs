using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public Text highScoreText;

    void Start()
    {
        int savedHighScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Highest Score: " + savedHighScore.ToString();
    }

    [ContextMenu ("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (gameOverScreen.activeSelf == false)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            dingSFX.Play(); 
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        EndGame();
    }

    public void EndGame()
    {
        // Check if the new score is better than the old one
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            // Save the new score
            PlayerPrefs.SetInt("HighScore", playerScore);
            PlayerPrefs.Save(); // Forces Unity to write it to the disk
        }

        // Update the UI
        highScoreText.text = "Highest Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
