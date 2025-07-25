using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerController player { get; private set; }
    private ResourceController _playerResourceController;

    [SerializeField] private int currentWaveIndex = 0;

    private EnemyManager enemyManager;

    private UIManager uiManager;
    public static bool isFirstLoading = true;

    public GameObject triggerObject;

    private int maxWaveRecord = 0; // �ְ� ���

    private void Awake()
    {
        instance = this;
        player = FindObjectOfType<PlayerController>();
        player.Init(this);

        uiManager = FindObjectOfType<UIManager>();

        _playerResourceController = player.GetComponent<ResourceController>();
        _playerResourceController.RemoveHealthChangeEvent(uiManager.ChangePlayerHP);
        _playerResourceController.AddHealthChangeEvent(uiManager.ChangePlayerHP);

        enemyManager = GetComponentInChildren<EnemyManager>();
        enemyManager.Init(this);

        maxWaveRecord = PlayerPrefs.GetInt("BestWaveRecord", 0);
        uiManager.ChangeScore(currentWaveIndex, maxWaveRecord);
    }

    private void Start()
    {

    }


    public void StartGame()
    {
        currentWaveIndex = 0;
        triggerObject.SetActive(false);
        uiManager.SetPlayGame();
        StartNextWave();
    }

    void StartNextWave()
    {
        currentWaveIndex += 1;

        if (currentWaveIndex > maxWaveRecord)
        {
            maxWaveRecord = currentWaveIndex;
            PlayerPrefs.SetInt("BestWaveRecord", maxWaveRecord); // ���� �߰�
            PlayerPrefs.Save();  // ���� Ȯ���� �ϱ� ���� ȣ��
        }

        uiManager.ChangeWave(currentWaveIndex);
        uiManager.ChangeScore(currentWaveIndex, maxWaveRecord); // ScoreUI ���

        enemyManager.StartWave(1 + currentWaveIndex / 5);
    }

    public void EndOfWave()
    {
        StartNextWave();
    }

    public void GameOver()
    {
        enemyManager.StopWave();
        uiManager.SetGameOver();
        triggerObject.SetActive(true);
    }

}
