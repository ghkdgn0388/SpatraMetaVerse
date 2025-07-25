using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "EscapeScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // �÷��̾� �±׸� ���� ������Ʈ�� ������ ���� ����
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
