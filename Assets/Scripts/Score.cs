using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI textScore;
    private int Score;
    void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        textScore.text = "Score: 0";
    }
    void OnEnable()
    {
        Enemy.ScoreAdd += ScoreAdded;
    }
    void OnDisable()
    {
        Enemy.ScoreAdd -= ScoreAdded;
    }
    private void ScoreAdded(int points)
    {
        Score += points;
        textScore.text = $"Score: {Score}";
    }
}