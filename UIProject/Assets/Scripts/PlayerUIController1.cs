using UnityEngine;
using TMPro;


public class PlayerUIController1 : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TMP_Text infoText;

    private Player player;
 
    void Start()
    {
        player = new Player();
        dropdown.onValueChanged.AddListener(OnDropdownChanged);
        OnDropdownChanged(dropdown.value);
    }

    void OnDropdownChanged(int index)
    {
        switch (index)
        {
            case 0:
                player.name = "MS";
                player.job = "전사";
                player.gender = "남";
                break;
            case 1:
                player.name = "SM";
                player.job = "마법사";
                player.gender = "여";
                break;
            case 2:
                player.name = "MSM";
                player.job = "궁수";
                player.gender = "남";
                break;
            default:
                player.name = "???";
                player.job = "???";
                player.gender = "???";
                break;
        }
        UpdateUI();
    }

    void UpdateUI()
    {
        infoText.text = $"이름: {player.name}\n직업: {player.job}\n성별: {player.gender}";
    }
}
