using UnityEngine;

public class TextMeshProSample : MonoBehaviour
{
    //TMP�� ����ϴ� UI �����͵�
    public TMPro.TextMeshProUGUI textUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //��ġ �ؽ�Ʈ(HTML �±� ���� ����) ����
        textUI.text = "<size=150%>�ȳ��ϼ���</size><s>�� �� ���</s>";

    }

    public void SetText(bool warning)
    {
        if (warning)
        {
            textUI.text = "<color=red><b>WARNING!!!<b></color>";


        }
        else
        {
            textUI.text = "<color=green>NORMAL</color>";
        }
        }
    }
