using UnityEngine;
using UnityEngine.Events;
//UnityEngine.Events ���ӽ����̽� ������ �ʼ��Դϴ�.

//C#�� event���� ������
//1. �ν����Ϳ��� Ȯ���� �����ϴ�.
//2. �߰� ���� ����� +=, -=���� ���� �ʰ� AddListener �� RemoveListener �� �����մϴ�.


//                            UnityAction          UnityEvent
//Ÿ��                           delegate            class
//���                           �Լ� ����         �����Ϳ��� �ڵ鷯 ������� ����
//����                             +,-          AddListener(), RemoveListener()
//����һ�Ȳ               ��ũ��Ʈ �ڵ峻ó��        �ν����Ϳ� �̺�Ʈ �ý���
//�ӵ�                            ����                 ����(���� ������ ���� �Ľ� �� ��Ÿ�� ���� ���)
//�޸�                          ����                 ����
//GC�߻�����                      ����                  ����
//���Ǽ�                     ��ü ���� �ؾ���        �ٷ� ��밡��, ���� ����


//UnityAction�� UnityEvent�� ����ϴ� �ڵ带 ������ �� ȿ�����Դϴ�.
//�Ϲ� delegate�� UnityAction<T>�� ���� Ÿ�Կ� ���� ������ �ȵǾ��־� ���� ���� ����ؾ� �մϴ�.

//����� �� �ִ� ������
//1. C# delegate
//2. Unity unityAction
//3, C# Func<T>,Action<T>

public class EventSample3 : MonoBehaviour
{
    public UnityEvent OnKButtonEnter;
    public UnityAction OnAction;

    private void Start()
    {
        //OnKButtonEnter += Sample; //����
        OnKButtonEnter.AddListener(Sample);
        OnAction += Sample;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            OnKButtonEnter?.Invoke();
        }
    }

    private void Sample()
    {
        Debug.Log("<color=cyan>Sample ����</color>");
    }

    private void Sample2()
    {
        Debug.Log("<color=cyan>Sample2 ����</color>");
    }

}
