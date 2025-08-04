using System;
using System.Collections;
using UnityEngine;

public class IEnumeratorSample : MonoBehaviour
{
    class CustomCollection : IEnumerable
    {
        int[] numbers = { 6, 7, 8, 9, 10 };

        //GetEnumerator�� ���� ��ȸ ������ �����͸� IEnumerator ������ ��ü�� ��ȯ�մϴ�.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers[i];
            }
        }
    }

    int[] numbers = { 1, 2, 3, 4, 5 };

    void Start()
    {
        //numbers��� �迭�� ��ȸ�� �� �ִ� IEnumerator ������ �����ͷ� ��ȯ�մϴ�.
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }

        CustomCollection collection = new CustomCollection();  //Ŀ���� �÷��� ���� 

        //foreach�� ��ȯ ������ �����͸� ���������� �۾��� �� ����ϴ� for�������� ���Ⱑ ���������ϴ�.
        foreach (int number in collection)
        {
            Debug.Log(number);
        }

        foreach (var number in GetMessages())
        {
            Debug.Log(number.ToString());
        }
    }

    //yield�� C#���� �� ���� �ϳ� �� ���� �ѱ��, �޼ҵ尡 �Ͻ� ���� �Ǹ� �ļ� ������
    //���������� ��ȯ�ϰ� �մϴ�.(�ݺ����� �۾�, �������� ������ ó���� ���˴ϴ�.)

    //yield�� yield return , yield break�� ���˴ϴ�.

    //yield return�� �޼ҵ尡 ���� ��ȯ�ϸ鼭 �� �������� �޼ҵ� ������ �Ͻ� ���� ��ŵ�ϴ�.
    //ȣ���ڰ� ���� ���� �䱸�� ������ ����մϴ�.

    //yield break�� �޼ҵ忡���� �ݺ��� �����ϴ� �ڵ��Դϴ�.(���� ����)

    //yield return�� ����ϴ� �޼ҵ�� IEnumerable �Ǵ� IEnumerator �������̽��� �����ϰ� �˴ϴ�.
    //�÷����� �ڵ����� ��ȸ�ϴ� foreach�� ���� ���˴ϴ�.

    //���� : ���� �ʿ�� �� ������ ����� �̷�� ���(�޸� ȿ���� ����, ū �����͸� ó���� �� ������ Ů�ϴ�.)
    // --> ��� �����͸� �����ϴ°� �ƴ� �ʿ��� �κи� ó���� �� �ְ� �Ǳ� ����

    //IEnumerable : �ݺ� ������ �÷����� ��Ÿ���� �������̽��Դϴ�.
    //              �� ����� ������ Ŭ������ �ݺ��� �� �ִ� ��ü�� �Ǹ�
    //              foreach ��� �������� Ž���� ������ �� �ְ� �˴ϴ�.
    //              �ش� �������̽��� �����ϱ� ���ؼ��� GetEnumerator() �޼ҵ带 �����ϰ�, ����ڰ�
    //              �����ؾ� �մϴ�.

    //IEnumerator : �ݺ��� �����ϴ� �������̽��Դϴ�.
    //              �÷��ǿ��� �ϳ��� �׸���� ��ȯ�ϰ�, �� ���¸� �����ϴ� ������ �����մϴ�.
    //              MoveNext()�� ���ؼ� ���� ���� ����
    //              Current�� ���ؼ� ���� �� Ȯ��
    //              Reset()�� ���ؼ� ���� ��� ó��


    static IEnumerable GetMessages()
    {
        Debug.Log("�޼ҵ� ����");
        yield return 1;
        //�߸� ��������, �ٽ� �ش� �޼ҵ�� ���ƿɴϴ�.
        Debug.Log("Ż�� �ߴٰ� ���ƿ� 1");
        yield return 2;
        Debug.Log("Ż�� �ߴٰ� ���ƿ� 2");
        yield break; // ��ȯ �۾� ����

        //-- Unreachable Code -- (���� �Ұ�)
        Debug.Log("Ż�� �ߴٰ� ���ƿ� 3");
        yield return 3;
    }


}