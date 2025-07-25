using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void Init()
    {
        // 초기화 필요 시
    }

    public void UpdateScore(int currentWave, int bestWave)
    {
        scoreText.text = $"Wave : {currentWave} / Best: {bestWave}";
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
