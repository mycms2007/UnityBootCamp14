using System.Collections.Generic;
using System;
using NUnit.Framework;
using UnityEngine;

public class InspectorAttributes : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStat  // 사용자 정의 타입 / Value 타입 /GC필요 없음(작은 데이터의 묶음을 자주 할당
        //복사하는 개념에서 활용 ex) Vector3)
    {
        public string name;
        public string description;
    }

    //[Serializable]
    public class Item // 객체를 위한 설계도(속성과 기능)/ 유니티에서는 class사용권장
    {
        public string name;
        public string description;
    } 
    [Header("Stat")]
    public int hp;
    public int mp;
    public int str;
    public int dex;
    public int wiz;
    public int luc;

    [Header("Skill")]
    public string grade;

    //직업 : 전사, 도적, 궁수, 마법사
    public Stat stat_bonus;
    public Skill Skill_list;

    //인스펙터에 공개하기 싫은 값에 대한 설정
    [HideInInspector]
    public int value = 5;

    //유니티에서 비공개 필드를 인스펙터에 노출시키고 유니티의 직렬화 시스템에 포함시킵니다.
    //사용목적
    //public : 노출 + 접근 가능
    //private : 노출 x 접근 x
    //SerializeField + private : 노출 X, 인스펙터에서 편집 가능

    //※ 직렬화(Serialization) : 데이터를 저장 가능한 형식으로 변환하는 작업
    //이 변환을 통해 씬, 프리팹, 에셋 등에 저장하고 복원하는 작업을 수행할 수 있습니다.

    //직렬화 조건
    //1.public or SerializeField
    //2.static이 아닌 경우
    //3.직렬화 가능한 데이터 타입인 경우

    //직렬화가 가능한 데이터
    //1.기본 데이터(int, float, bool, string ...)
    //2.유니티에서 제공해주는 구조체(vecto3, Quaternion, Color)
    //3.유니티 객체 참고(GameObject, Transform, Material)
    //4.[Serializable] 속성이 붙은 클래스
    //5.배열/리스트 

    //직렬화 불가능한 데이터
    //1.Dictionary <K,V>
    //2,interface (인터페이스)
    //3.static 키워드가 붙은 필드
    //4,abstract 키워드가 붙은 클래스
    [SerializeField]
    private int effect;


    //Space(높이) : 적은 높이만큼 간격이 생깁니다.



    //문자열이 장문일 경우 유용한 속성
    //기본은 1줄, 설정을 넣으면 그 수치만큼 칸이 늘어납니다.
    //[TextArea]만 등록할 경우 여러 줄 입력이 가능한 상태가 됩니다.
    //[TextArea(기본 표시 줄, 최대줄)]을 통해 인스펙터 상에서의 높이를 제어합니다.
    //문자열 길이에 대한 제한적인 부분은 없습니다.

    [Space(10)]
    [TextArea(3,5)]
    public string skill_info;



    //유니티 인스펙터에서는 배열도 리스트로 나오게 됩니다.
    //리스트<T>는 T 형태의 데이터를 묶음으로 순차적으로 저장할 수 있는 데이터입니다.
    //데이터의 검색, 추가, 삭제 등의 기능이 제공됩니다.
    public List<Item> item_liset;

    public PlayerStat[] Droprate = new PlayerStat[5];
    
    public enum Stat
    {
        str, dex, wiz, luc
    }
    public enum Skill
    {
        Bash, Power_strike, hard_skin, endure
    }

    //Range(최소, 최대)를 통해 해당 값을 에디터에서 최소 값과 최대가 설정되어있는
    //스크롤 형태의 값으로 변경됩니다. (범위 제한)

}
