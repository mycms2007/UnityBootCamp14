using UnityEngine;

public class Sample : MonoBehaviour
{
    public string[] Parse(string requirement)
    {
        return requirement.Split('+');  // ¿¹: "100 °ñµå + ·çºñ" ¡æ ["100 °ñµå", " ·çºñ"]
    }
}