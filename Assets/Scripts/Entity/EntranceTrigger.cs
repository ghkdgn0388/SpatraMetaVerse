using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceTrigger : MonoBehaviour
{
    public GameObject targetUI;
    public GameObject entranceGate; // ó���� ��Ȱ��ȭ�� ��

    private bool isGateClosed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            targetUI.SetActive(true);

            if (!isGateClosed)
            {
                entranceGate.SetActive(true); // �� Ȱ��ȭ (���̰�, �浹�� ����)
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
        targetUI.SetActive(false);      // UI ����
        entranceGate.SetActive(false);  // �� ����
        isGateClosed = false;           // ���� �ʱ�ȭ
    }

}
