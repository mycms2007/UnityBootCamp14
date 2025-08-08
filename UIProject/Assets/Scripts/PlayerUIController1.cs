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
                player.job = "����";
                player.gender = "��";
                break;
            case 1:
                player.name = "SM";
                player.job = "������";
                player.gender = "��";
                break;
            case 2:
                player.name = "MSM";
                player.job = "�ü�";
                player.gender = "��";
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
        infoText.text = $"�̸�: {player.name}\n����: {player.job}\n����: {player.gender}";
    }
}
