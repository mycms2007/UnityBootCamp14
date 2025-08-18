using UnityEngine;
using System;

//C#�� Event ����
//Ŭ���̳� ��ġ�� ���� ������ ó���ϴ� �ϳ��� �ý���

//������(Publisher)
//������� �ൿ�� ��ٸ��ٰ� �����ڿ��� �˷��ִ� ������ �����մϴ�.



//������(Subscribers)
//�̺�Ʈ �����ڿ� ���� ������ ���� ������� �ൿ�� ���޹޾Ƽ� �����ϴ� ������ ����.


//�������� ���, �������� �ൿ ��ü�� �����ڰ� �˾ƾ��� �ʿ�� ���� ����.
//�������� ��� ���к��ϰ� ������ ��� ���õ� �����ڵ��� ����� ����� �� ����.

//event ����� ���ؼ� System ���ӽ����̽��� ����ؾ� �մϴ�.



public class EventSample : MonoBehaviour
{
    public event EventHandler OnSpaceEnter;
    //�̺�Ʈ ������ �̸��� ���� On+���� / ������ ��������ϴ�.

    //C#���� �������ִ� delegate Ÿ��
    //EventHandler�� ��� ��ġ�� Ŭ�� ���� �̺�Ʈ�� �����ϴ� �뵵
    //�Ű�����
    //Object sender <- object Ÿ���� �����͸� ���޹��� �� ������,
    //�̺�Ʈ�� �߻���Ų ����� �ǹ��մϴ�.

    //EventArgs e <- �̺�Ʈ�� ���õ� �����͸� ��� �ִ� ��ü�� �ǹ��մϴ�.
    //�ش簪�� EventArgs �Ǵ� �ش� �ڽ� Ŭ������ �� �� �ֽ��ϴ�.

    private void Start()
    {
        //���� ���
        //�̺�Ʈ�� += ���¿� �´� �޼ҵ� �̸�;
        OnSpaceEnter += Debug_OnSpaceEnter;

    }



    // Update is called once per frame
    void Update()
    { 
     //1) �̺�Ʈ ���� ��� �̺�Ʈ��(this.EventArgs.Empty)
        if(Input. GetKeyDown(KeyCode.Space)) // �����̽� ��ư Ŭ��
        {
            //Null �˻縦 �����ϰ� ����(�̺�Ʈ ������ �ȵǾ����� ��쿡�� �����ϸ� �ȵǱ� ����
            if(OnSpaceEnter != null)
            {
                OnSpaceEnter(this, EventArgs.Empty);
            }
            //this : �̺�Ʈ�� �߻���Ų ��ü (���� Ŭ����)
            //EventArgs.Empty : �̺�Ʈ ���࿡ �־� Ư���� �߰��Ǵ� �����Ͱ� ������ �ǹ��մϴ�.
        }
     //2) �̺�Ʈ ���� ��� Invoke �Լ��� ����ϴ� ���
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽� ��ư Ŭ��
        {
           OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            //?.�� ���� null�� �ƴ� �� ó���ǵ��� �Ѵ�.

            //int?�� ���� �ڷ����� ����ǥ�� ���̰� Nullable �� Ÿ������ ����ϴ� ���
            //������������ null���� ���� �� �ְ� ���ݴϴ�.(T? ����)
            //Ÿ���� ������ �� ����մϴ�.
            //�� ������ Ÿ�Կ� ���˴ϴ�.


            //?.�� ���·� ���̴� ���, Null ���� �����ڷ� ���Ǵ� ���
            //��ü�� null�� �ƴ� ������ ����� ���� ȣ���� �����ϵ��� �����մϴ�.
            //�޼ҵ�(Method), �Ӽ�(Property), �̺�Ʈ(Event) ���� ȣ�� �ÿ� ���˴ϴ�.
            //���۷��� ������ Ÿ�� �Ǵ� nullable ��ü�� ������� �մϴ�.

            // >> if(ojb != null) ������ �ڵ� ��� ����մϴ�.
        }

    }

    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow>���� Ű �Է� �̺�Ʈ ����</color>");
    }
}
