using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private TMP_Text score;
    private int currentScore;

    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("UIScore").GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        Present.scoreUpdater += UpdateScore;
    }
    private void OnDisable()
    {
        Present.scoreUpdater -= UpdateScore;
    }
    private void UpdateScore(int addScore)
    {
        int newScore = currentScore += addScore;
        score.text = "Cadeau's Opgepakt: " + newScore;
    }
}
