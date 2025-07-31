using UnityEngine;
using UnityEngine.UI;

//Ű�� �Է��ϸ� �ؽ�Ʈ�� Ư�� �޽����� �������� �ϴ� �ڵ�


public class LegacyExample : MonoBehaviour
{
    public Text text;

    KeyCode key;

    private void Start()
    {
        text = GetComponentInChildren<Text>();
        //GetComponentInChildren<T>();
        //�� ������Ʈ�� �ڽ����κ��� ������Ʈ�� ������ ���
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Space Ű
        {
            text.text = "pata";
        }

        if (Input.GetKeyDown(KeyCode.Return)) //Enter Ű
        {
            text.text = "pong";
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // ESC Ű
        {
            text.text = "";
        }

        //�迭�� ���� �������� �����Ǵ� �����͸� ���������� �����ϴ� �ڵ�
        //foreach(������ ������ in ����)

        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
            {
                switch (key)
                {
                    case KeyCode.Escape:
                        text.text = "";
                        break;

                    case KeyCode.Space:
                        text.text = "pata";
                        break;

                    case KeyCode.Return:
                        text.text = "pong";
                        break;




                }


            }

        }
    }
}