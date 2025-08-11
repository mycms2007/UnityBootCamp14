using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject characterPanel; // 캐릭터 설정창
    public GameObject continueButton; // 이어하기 버튼

    private void Start()
    {
        // 캐릭터 정보가 없으면 이어하기 버튼 비활성화
        if (!PlayerPrefs.HasKey("CharacterName"))
        {
            continueButton.SetActive(false);
        }
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll(); // 캐릭터 정보 삭제
        characterPanel.SetActive(true); // 캐릭터 설정창 켜기
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
        Debug.Log("데이터 초기화");
    }

    // 캐릭터 생성 확인 버튼
    public void ConfirmCharacter()
    {
        // 예시: 캐릭터 이름 저장 (실제로는 UI InputField에서 값 가져오기)
        PlayerPrefs.SetString("CharacterName", "용사");
        SceneManager.LoadScene("NextScene");
    }

    // 캐릭터 생성 취소 버튼
    public void CancelCharacter()
    {
        characterPanel.SetActive(false);
    }
}