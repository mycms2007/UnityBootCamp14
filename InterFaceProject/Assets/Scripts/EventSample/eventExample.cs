using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
/*(public class Tester : MonoBehaviour
{
    private void Start()
    {
        eventExample eventExample = new eventExample();
        eventExample.onDeath?.Invoke();
       // eventExample.onStart?.Invoke(); // event Ű���尡 ���� ��� �ܺο����� ȣ�� �Ұ���
        eventExample.onDeath = null;
        //eventExample.onStart = null; // event Ű����� ������ �Ұ���

        eventExample
    }

    private void Samples()
    {

    }
}
*/





//C# event p.526
//event : Ư�� ��Ȳ�� �߻������� �˸��� ������ ��Ŀ����
//1. �÷��̾ �׾��� ��, �˸� ����, �޼ҵ� ȣ��



//              Action          vs              event Action
//�ܺ� ȣ��        O                                  X
//�ܺ� ����        O                                  X
//���� ���        O                                  X
//���� ���        O                                  O
//�� �뵵      ���η���,�ѹ�                        �̺�Ʈ �˸�


public class eventExample : MonoBehaviour

    //Action vs event Action??


{
    Action onDeath;
    event Action onStart;


    public void Start()
    {
        //�׼��� +=�� ���� �Լ�(�޼ҵ�)�� �׼ǿ� ����� �� �ֽ��ϴ�. (����)
        //�׼��� -+�� ���� �Լ�(�޼ҵ�)�� �׼ǿ��� ������ �� �ֽ��ϴ�.(����)
        //�׼��� ����� ȣ���ϸ� ��ϵǾ��ִ� �Լ��� ���������� ȣ��˴ϴ�.
        onStart += Ready;
        onStart += Fight;


        onDeath += Damaged;
        onDeath += Dead;

        onStart?.Invoke(); //onStart�� ��ϵ� ����� �����ϴ� �ڵ� Invoke();
        onDeath?.Invoke();

        //�Լ�ó�� ȣ���ϴ� �͵� �����մϴ�.
     
        onStart();
        onDeath();
        //���� ����? ����. ���� ��Ÿ�� ����
        //Invoke ����̸�  null üũ ����, �ܺο����� ȣ��, ������ �䱸 �� ��õ
        //�Լ� ���¸� ���� ����, �����ڵ��̰ų� �ܼ� ȣ���� ��� �ش� ��� ��õ

    }

    public void Fight()
    {
        Debug.Log("<color=yellow><b>Fight!!</b></color>");
    }

    public void Ready()
    {
        Debug.Log("<color=cyan><b>Ready??</b></color>");
    }

    public void Dead()
    {
        Debug.Log("<color=blue><b>A Hero is fallen.</b></color>");

        
    }

    public void Damaged()
    {
        Debug.Log("<color=red><b>Critical Damage!</b></color>");
    }
}
