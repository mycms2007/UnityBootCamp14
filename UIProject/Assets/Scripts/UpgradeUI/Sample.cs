using UnityEngine;

public class Sample : MonoBehaviour
{
    public string[] Parse(string requirement)
    {
        return requirement.Split('+');  // ��: "100 ��� + ���" �� ["100 ���", " ���"]
    }
}