using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "EscapeScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 플레이어 태그를 가진 오브젝트가 들어왔을 때만 실행
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
