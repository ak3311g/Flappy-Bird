using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score;
    public Text scoreText;
    public GameObject gameOverPanel;

    public void AddScore(){
        Score++;
        scoreText.text = "Score: " + Score.ToString();
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver(){
        gameOverPanel.SetActive(true);
    }
}