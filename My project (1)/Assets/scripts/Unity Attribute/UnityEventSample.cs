using UnityEngine;
using UnityEngine.Events;


public class UnityEventSample : MonoBehaviour
{
    //������ �ν����Ϳ��� �ʵ� ���� ���콺�� �÷��� �� ������ �����ִ� ���
    [Tooltip("�̺�Ʈ ����Ʈ�� �߰��ϰ�, ������ ����� ���� ���� ������Ʈ�� ����ϼ���.")]
    public UnityEventSample action;

    private void Update()
    {
        action.Move();  //�׼ǿ� ��ϵ� �Լ��� �����մϴ�.
    }





    public void Move()
    {
        gameObject.transform.Translate(0, 1, 0);
    }
}
