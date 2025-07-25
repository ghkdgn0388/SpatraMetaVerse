using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceTrigger : MonoBehaviour
{
    public GameObject targetUI;
    public GameObject entranceGate; // 처음에 비활성화된 문

    private bool isGateClosed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            targetUI.SetActive(true);

            if (!isGateClosed)
            {
                entranceGate.SetActive(true); // 문 활성화 (보이고, 충돌도 생김)
                isGateClosed = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            targetUI.SetActive(false);
        }
    }

    public void OnExitButtonClicked()
    {
        targetUI.SetActive(false);      // UI 끄기
        entranceGate.SetActive(false);  // 문 끄기
        isGateClosed = false;           // 상태 초기화
    }

}
