using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCollision : MonoBehaviour
{
    public ScoreHandler scoreHandler;
    public GameObject gameOverPanel;
    
    private TextMeshProUGUI _scoreText;
    private TextMeshProUGUI _finalScoreText;

    void Start()
    {
        Time.timeScale = 1;
        _scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        _finalScoreText = GameObject.Find("FinalScoreText").GetComponent<TextMeshProUGUI>();
        gameOverPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Obstacle")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            _scoreText.enabled = false;
            gameOverPanel.SetActive(true);
            GameObject.Find("IsInvisibleText").GetComponent<TextMeshProUGUI>().enabled = false;
            _finalScoreText.text = $"Your score : {scoreHandler.GetScore()}";
        } 
        else if (other.gameObject.name == "Coin") 
        {
            Destroy(other.gameObject);
            scoreHandler.SetScore(5);
        }
    }
}
