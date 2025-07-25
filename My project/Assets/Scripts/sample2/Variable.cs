using System;
using UnityEngine;
//유니티 인스펙터에서 변수에 대한 표현을 확인하는 코드

[Flags]
public enum TYPE
{
    불, 물, 풀
}
//여러개를 선택하는 기능(Flag)
//값을 2의 제곱수로 표현합니다.
//2의 제곱수는 비트 연산으로 표현하기가 쉽습니다. n<<1이면 n의 제곱, n<<2면 n의 2제곱.
[Flags]
public enum TYPE2
{
    독 = 1 << 0,
    고스트 = 1 << 1,//1에서 1칸 이동하겠습니다. (비트 연산)
    드래곤 = 1 << 2,
    얼음 = 1<<3,
}
public class Variable : MonoBehaviour
{
    //데이터 앞에 u가 붙으면 양수만 표현하는 것을 의미합니다.
    //ex) int의 표현 범위는 -2147483648 ~ 2147483647
    //ex) uint로 사용할 경우라면 0 ~ 4294967295

    //null은 "값이 없음"을 나타내는 값. (0이나 empty와 다른 개념)

    //유니티에서 자주 사용되는 c# 기본 데이터 타입(primitive)
    //정수(int/uint)
    //실수(float)
    //논리(bool)
    //문자열(string)
    //널 값 허용(nullable) : 자료형?로 작성하면 해당값은 null을 사용할 수 있음.

    public int Integer;
    public float Float;
    public string Sentence;

    public TYPE type;
    public bool isDead;
    public TYPE2 type2;
    }


