using System;
using UnityEngine;
using System.IO;
using UnityEngine.Rendering;

public class JasonMaker : MonoBehaviour
{
    [Serializable]
    public class QuestData
    {
        public string quest_name;
        public string reward;
        public string description;

    }

    [Serializable]
    public class QuestList
    {
        public QuestData[] quests;
    }

    private void Start()
    {
        QuestList list = new QuestList();
        {
            list.quests = new QuestData[]
            {
                //new �����ڸ�(){�ʵ�� = ��, �ʵ��2 = ��2 ...} �ش� ������ ���� ���� Ŭ���� ��ü�� �����˴ϴ�.



                new QuestData() { quest_name = "������ ���̴�", reward = "exp +100", description = "�����̶� �ϸ� ���̶� ����." },

                new QuestData() { quest_name = "�߰��� �ض�", reward = "exp +150", description = "�߰��̶� �ϴ°� ����." },

            new QuestData() { quest_name = "�ҰŸ� ������ �ض�.", reward = "exp +500", description = "�׳� ���϶�� ���ݾ�.." }
            };
    }

        // JsonUtility, ToJson(Object, pretty_print);�� ���� C#�� ��ü�� JSON���� �������ִ� ����ȭ ����� ���� �Լ�

        string json = JsonUtility.ToJson(list, true);
        //ToJson(��ü)�� �ش� ��ü�� JSON ���ڿ��� �������ִ� �ڵ�
        //true�� �߰��� ���, �鿩����� �ٹٲ��� ���Ե� ������ json ���Ϸ� �������ݴϴ�.
        //false�� ���ų� �����ϴ� ����� ���� �� �ٷ� ����� json ���Ϸ� �����˴ϴ�.

        // ���� ��ο� ���� �ۼ��� �����մϴ�.
        Debug.Log($"�� ���� ���� ��ġ : {Application.persistentDataPath}");
        
        //Path,Combine(string path1, string path2);
        //�� ����� ���ڿ��� �ϳ��� ��η� ������ִ� ����� ������ �ֽ��ϴ�.
        //���� ��ġ/ ���ϸ����� ���� ���˴ϴ�.

        //Application.persistentDataPath : ����Ƽ�� �� �÷������� �����ϴ� ���� ���� ������ ���� ���

        //�ش� ��ο� ������ �ۼ�
        string path = @"C:\Users\Xenus\Desktop\quests.json";
        File.WriteAllText(path, json);
        //C# 723 page : System. 10 ���ӽ����̽�
        //   725 page : PathŬ������ ���� ���� �̸�, Ȯ����, ���� ���� ��� ���
        //   733 page : Json �����Ϳ� ���� ����

        Debug.Log("JSON ���� ���� �Ϸ�");

        //=================���Ϸε�============
        //1) �ش� ��ο� ������ �����ϴ��� �Ǵ��ϼ���.

        if(File.Exists(path))
        {
            //���� �ؽ�Ʈ�� ���� �о ������ �����ͷ� �����մϴ�.
            string json2 = File.ReadAllText(path);

            QuestList loaded = JsonUtility.FromJson<QuestList>(json2);

            Debug.Log($"����Ʈ ����: {loaded.quests[0].quest_name}");

        }
        else
        {
            Debug.LogWarning("�ش� ��ο� ����� JSON ������ �����ϴ�.");
        }
    }
}

