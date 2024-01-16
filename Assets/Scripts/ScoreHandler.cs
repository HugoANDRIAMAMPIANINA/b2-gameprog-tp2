using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    private int _score;
    private TextMeshProUGUI _scoreText;
    private IEnumerator _coroutine;
    
    void Start()
    {
        _score = 0;
        _scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        _scoreText.text = $"Score : {_score}";
        _coroutine = UpdateScoreEachSecond(); 
        StartCoroutine(_coroutine);
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int scoreToAdd) 
    {
        _score += scoreToAdd;
        _scoreText.text = $"Score : {_score}";
    }

    IEnumerator UpdateScoreEachSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            SetScore(1);
        }
    }
}
