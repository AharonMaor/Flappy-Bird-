using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScroe;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;

    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        playerScroe += scoreToAdd;
        scoreText.text = playerScroe.ToString();
        dingSFX.Play();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
