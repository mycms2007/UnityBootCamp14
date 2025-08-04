using UnityEngine;

public class SampleSpawner : MonoBehaviour
{
    
    void Start()
    {
        GameObject sample = GameObject.Find("Sample");

        //오브젝트 탐색 결과가 없을 경우
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
