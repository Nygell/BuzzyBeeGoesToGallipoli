using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText;
    private float _score;
    public float Score { get => _score; private set => _score = value; }

    private void Awake()
    {
        EventsManager.OnScoreChange += UpdateScore;
    }

    private void UpdateScore(float score)
    {
        Score += score;
        _scoreText.text = $"Score: {Score}";
    }
}
