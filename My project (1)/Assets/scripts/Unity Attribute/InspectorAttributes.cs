using System.Collections.Generic;
using System;
using NUnit.Framework;
using UnityEngine;

public class InspectorAttributes : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStat  // ����� ���� Ÿ�� / Value Ÿ�� /GC�ʿ� ����(���� �������� ������ ���� �Ҵ�
        //�����ϴ� ���信�� Ȱ�� ex) Vector3)
    {
        public string name;
        public string description;
    }

    //[Serializable]
    public class Item // ��ü�� ���� ���赵(�Ӽ��� ���)/ ����Ƽ������ class������
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

    //���� : ����, ����, �ü�, ������
    public Stat stat_bonus;
    public Skill Skill_list;

    //�ν����Ϳ� �����ϱ� ���� ���� ���� ����
    [HideInInspector]
    public int value = 5;

    //����Ƽ���� ����� �ʵ带 �ν����Ϳ� �����Ű�� ����Ƽ�� ����ȭ �ý��ۿ� ���Խ�ŵ�ϴ�.
    //������
    //public : ���� + ���� ����
    //private : ���� x ���� x
    //SerializeField + private : ���� X, �ν����Ϳ��� ���� ����

    //�� ����ȭ(Serialization) : �����͸� ���� ������ �������� ��ȯ�ϴ� �۾�
    //�� ��ȯ�� ���� ��, ������, ���� � �����ϰ� �����ϴ� �۾��� ������ �� �ֽ��ϴ�.

    //����ȭ ����
    //1.public or SerializeField
    //2.static�� �ƴ� ���
    //3.����ȭ ������ ������ Ÿ���� ���

    //����ȭ�� ������ ������
    //1.�⺻ ������(int, float, bool, string ...)
    //2.����Ƽ���� �������ִ� ����ü(vecto3, Quaternion, Color)
    //3.����Ƽ ��ü ����(GameObject, Transform, Material)
    //4.[Serializable] �Ӽ��� ���� Ŭ����
    //5.�迭/����Ʈ 

    //����ȭ �Ұ����� ������
    //1.Dictionary <K,V>
    //2,interface (�������̽�)
    //3.static Ű���尡 ���� �ʵ�
    //4,abstract Ű���尡 ���� Ŭ����
    [SerializeField]
    private int effect;


    //Space(����) : ���� ���̸�ŭ ������ ����ϴ�.



    //���ڿ��� �幮�� ��� ������ �Ӽ�
    //�⺻�� 1��, ������ ������ �� ��ġ��ŭ ĭ�� �þ�ϴ�.
    //[TextArea]�� ����� ��� ���� �� �Է��� ������ ���°� �˴ϴ�.
    //[TextArea(�⺻ ǥ�� ��, �ִ���)]�� ���� �ν����� �󿡼��� ���̸� �����մϴ�.
    //���ڿ� ���̿� ���� �������� �κ��� �����ϴ�.

    [Space(10)]
    [TextArea(3,5)]
    public string skill_info;



    //����Ƽ �ν����Ϳ����� �迭�� ����Ʈ�� ������ �˴ϴ�.
    //����Ʈ<T>�� T ������ �����͸� �������� ���������� ������ �� �ִ� �������Դϴ�.
    //�������� �˻�, �߰�, ���� ���� ����� �����˴ϴ�.
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

    //Range(�ּ�, �ִ�)�� ���� �ش� ���� �����Ϳ��� �ּ� ���� �ִ밡 �����Ǿ��ִ�
    //��ũ�� ������ ������ ����˴ϴ�. (���� ����)

}
