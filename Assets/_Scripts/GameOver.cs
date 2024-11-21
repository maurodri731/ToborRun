using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverCanvas;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int score = 0; 

    public void StopGame(int score) {
        gameOverCanvas.SetActive(true);
        scoreText.text = score.ToString(); 
        this.score = score; 
    }

    public void SubmitScore()
    {

    }

    public void AddXP(int score)
    {

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
