using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    public const string HighestScoreKey = "HighestScore";

    private float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighestScore = PlayerPrefs.GetInt(HighestScoreKey, 0);

        if(score > currentHighestScore)
        {
            PlayerPrefs.SetInt(HighestScoreKey, Mathf.FloorToInt(score));
        }
    }
}
