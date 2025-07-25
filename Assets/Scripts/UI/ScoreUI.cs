using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    public void Init()
    {
        // �ʱ�ȭ �ʿ� ��
    }

    public void UpdateScore(int currentWave, int bestWave)
    {
        scoreText.text = $"Best: {bestWave}";
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
