using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject characterPanel; // �ǳ� ���� ����

    public void ShowCharacterPanel()
    {
        characterPanel.SetActive(true);
    }
}