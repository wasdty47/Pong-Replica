using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreBoard : MonoBehaviour
{

    [SerializeField] private Text _scoreText;

    public void IncrementScore(){

        int score = Convert.ToInt32(_scoreText.text);
        score++;

        _scoreText.text = score.ToString();

    }

}
