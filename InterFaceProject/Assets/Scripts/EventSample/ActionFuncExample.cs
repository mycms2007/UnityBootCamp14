using System;
using UnityEngine;

public class ActionFuncExample : MonoBehaviour
{
    //Action<T>는 최대 16개의 매개변수를 받을 수 있습니다.
    //반환 값은 없습니다.(void)
    //전달이 목적이며, 결과는 받지 않는 형태

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
        Debug.Log($"분노로 인해 공격력이 <color=blue><b>{value}</b></color>만큼 상승합니다!");
    }
    void Heal(int value, string character)
    {
        Debug.Log($"회복 마법으로<color=yellow><b>{character}</b></color> <color=green><b>{value}</b></color>만큼 회복합니다.");
    }
}
