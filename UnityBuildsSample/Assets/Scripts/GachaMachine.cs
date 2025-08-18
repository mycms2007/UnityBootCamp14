using UnityEngine;
using System;


public class GachaMachine : MonoBehaviour
{
    [SerializeField] private string[] itemByNumber = new string[11];

    public event EventHandler<GachaEventArgs> OnDrawn;

    public void Draw()
    {
        int n = UnityEngine.Random.Range(1, 11);
        string item = (n < itemByNumber.Length) ? itemByNumber[n] : "";
        Debug.Log($"[Draw] ���� ����: {n}, ������: {(string.IsNullOrEmpty(item) ? "����" :item)}");

        OnDrawn?.Invoke(this, new GachaEventArgs(n, item));
    }
}