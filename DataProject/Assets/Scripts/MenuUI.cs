using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject characterPanel; // ĳ���� ����â
    public GameObject continueButton; // �̾��ϱ� ��ư

    private void Start()
    {
        // ĳ���� ������ ������ �̾��ϱ� ��ư ��Ȱ��ȭ
        if (!PlayerPrefs.HasKey("CharacterName"))
        {
            continueButton.SetActive(false);
        }
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll(); // ĳ���� ���� ����
        characterPanel.SetActive(true); // ĳ���� ����â �ѱ�
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("NextScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("������ �ʱ�ȭ");
    }

    // ĳ���� ���� Ȯ�� ��ư
    public void ConfirmCharacter()
    {
        // ����: ĳ���� �̸� ���� (�����δ� UI InputField���� �� ��������)
        PlayerPrefs.SetString("CharacterName", "���");
        SceneManager.LoadScene("NextScene");
    }

    // ĳ���� ���� ��� ��ư
    public void CancelCharacter()
    {
        characterPanel.SetActive(false);
    }
}