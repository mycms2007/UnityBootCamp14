using UnityEngine;

public class SampleSpawner : MonoBehaviour
{
    
    void Start()
    {
        GameObject sample = GameObject.Find("Sample");

        //������Ʈ Ž�� ����� ���� ���
        if(sample == null ) 
        {
            GameObject go = new GameObject("Sample");
            go.AddComponent<Sample>();
        }
        else
        {
            Debug.Log("");
        }
    }


}
