using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject characterPanel; // 판넬 넣을 변수

    public void ShowCharacterPanel()
    {
        characterPanel.SetActive(true);
    }
}