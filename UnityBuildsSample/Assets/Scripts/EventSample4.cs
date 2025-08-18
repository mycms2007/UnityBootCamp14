using UnityEngine;
using System;
public class DamageEventArgs : EventArgs
{

    //������ ���� ���� ����(������Ƽ �۾��ϸ�, get ��ɸ� �ַ� Ȱ��ȭ�մϴ�.)
    public int Value { get; } //Value�� ���� ���ٸ� ����

    public string EventName { get; }

    //EventArgs�� ���� ������ �߻��ϸ� ���� �����˴ϴ�.(������)



    public DamageEventArgs(int value, string eventName)
    {
        Value = value;
        EventName = eventName;
    }
}

    public class EventSample4 : MonoBehaviour
    {
    public event EventHandler<DamageEventArgs> OnDamaged; //�������� �޾��� ���� ���� �̺�Ʈ �ڵ鷯

        public void TakeDamage(int value, string eventName)
        {
            OnDamaged?.Invoke(this, new DamageEventArgs(value, eventName));

            Debug.Log("<color=red>[���!]�÷��̾ �������� �޾ҽ��ϴ�. </color>");
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TakeDamage(UnityEngine.Random.Range(10, 200), "���� ����");
            }
        }
    }

