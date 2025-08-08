using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//��Ӵٿ��� �������
//1. Template : ��� �ٿ��� �������� ��, ���̴� ����Ʈ �׸�
//2.Caption / Item Text : ���� ���õ� �׸� / ����Ʈ �׸� ������ ���� �ؽ�Ʈ.
// TMP�� ���� ���, �ѱ� ����� ���� Label�� Item Label���� ��� ���� ��Ʈ�� ������ �ּž� ����� �� �ֽ��ϴ�.

//3. Options : ��Ӵٿ ǥ�õ� �׸� ���� ����Ʈ
// �ν����͸� ���� ���� ����� �����մϴ�.
// ����ϸ� �ٷ� ����Ʈ�� ����˴ϴ�.

//4. On value Changed : ����ڰ� �׸��� �������� �� ȣ��Ǵ� �̺�Ʈ
// �ν����͸� ���� ���� ����� �� �ֽ��ϴ�.
// ��� �ٿ� ���� ���� ���� �߻� �� ȣ��˴ϴ�.
public class DropdownSample : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    //Options�� ����� ���� ���ڿ�


    //����Ʈ�� ���� �ְ� �����ϴ� ���
    //��Ʈ��<T> ����Ʈ�� = new ����Ʈ��<T>{���1,���2,���3};

    private List<string> options = new List<string> { "A", "B", "C" };


    private void Start()
    {
        dropdown.ClearOptions(); //��Ӵٿ��� Option ����� �����ϴ� �ڵ�

        dropdown.AddOptions(options); //�غ�� ��ܿ� ���� �߰�
        dropdown.onValueChanged.AddListener(onDropdownValueChanged);
        //�̺�Ʈ ��� �� �䱸�ϴ� �Լ��� ���´�� �ۼ��� �ƴٸ�
        //�Լ��� �̸��� �־� ����� �� �ְ� �˴ϴ�.

    }

    //C# System.Int32 ---> int
    // System.Int64 ----> long
    // System.UInt32 ---> unsigned int(��ȣ�� ���� 32��Ʈ ����) (0~4,294,967,295)
    void onDropdownValueChanged(int idx)
    {
        Debug.Log("���� ���õ� �޴���"+ dropdown.options[idx].text);
        //�ɼ� ����Ʈ�� idx��° ���� ���� �ؽ�Ʈ
    }
}
