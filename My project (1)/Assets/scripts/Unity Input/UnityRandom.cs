using UnityEngine;

public class UnityRandom : MonoBehaviour
{

    [ContextMenuItem("���� �� ȣ��","MenuAttributesMethod")]
    public int rand;


    public void MenuAttributesMethod()
    {
        //����Ƽ�� ���� Random.Range(�ּ�, �ִ�)
        //�ּ� �� ���� ����
        //�ִ� �� ���� x (����)

        //�ּ� �� ���� ����
        //�ִ� �� ���� o (�Ǽ�)

        rand = Random.Range(0, 10); //0~9
        // 0 1 2 3 4 5 6 7 8 9
        //���߿��� 9���� ���� ���� ���� Ȯ��? 90%

    }
}
