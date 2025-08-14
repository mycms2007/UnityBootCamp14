using System;
using UnityEngine;

public class ActionFuncExample : MonoBehaviour
{
    //Action<T>�� �ִ� 16���� �Ű������� ���� �� �ֽ��ϴ�.
    //��ȯ ���� �����ϴ�.(void)
    //������ �����̸�, ����� ���� �ʴ� ����

    public Action<int> myaction;
    public Action<int,string> myaction2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myaction += Rage;
        //myaction += Heal;
        //myaction2 += Rage;
        myaction2 += Heal;

        myaction(50);
        myaction2(40, "Steve");

    }

    void Rage(int value)
    {
        Debug.Log($"�г�� ���� ���ݷ��� <color=blue><b>{value}</b></color>��ŭ ����մϴ�!");
    }
    void Heal(int value, string character)
    {
        Debug.Log($"ȸ�� ��������<color=yellow><b>{character}</b></color> <color=green><b>{value}</b></color>��ŭ ȸ���մϴ�.");
    }
}
