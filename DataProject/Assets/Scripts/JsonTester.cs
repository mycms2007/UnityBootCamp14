using System;
using UnityEngine;

public class JsonTester : MonoBehaviour
{
    //����Ƽ���� ��ü(Object)�� �ʵ�(field)�� json���� ��ȯ�ϱ� ���ؼ���
    //���������� �޸𸮿��� �����͸� �а� ���� �۾��� �����ؾ� ��.
    //���� [Serializable] �Ӽ��� �߰��� �ش� ������ ���� ����ȭ�� ó������ �ʿ䰡 ����.

    //����ȭ�� �����͸� �����ϰų� �����ϱ� ���� �������� �������� ���·� �������ִ� �۾��� �ǹ�


    [Serializable]
    public class Data
    {
        public int hp;
        public int atk;
        public int def;
        public string[] items;
        public Position position;
        public string Quest;
        public bool isDead;

    }

    [Serializable]
    public class Position
    {
        public float x;
        public float y;

    }

    public Data my_data;



    void Start()
    {
        var jsonText = Resources.Load<TextAsset>("data01");

        if (jsonText == null)
        {
            Debug.LogError("�ش� JSON ������ ���ҽ� �������� ã�� ���߽��ϴ�!");
            return;

        }

        my_data = JsonUtility.FromJson<Data>(jsonText.text);

        Debug.Log(my_data.hp);
        Debug.Log(my_data.Quest);
        Debug.Log(my_data.def);
        Debug.Log(my_data.position.x);
        Debug.Log(my_data.position.y);
        foreach (var item in my_data.items)

        {
            Debug.Log(item);

        }
    }
}
