using UnityEngine;

public class BuildProfileSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
#if CUSTOM_DEBUG_MODE
        Debug.Log("����� ��忡�� ���� ���� ����Դϴ�!");
#elif  CUSTOM_RELEASE_MODE //���� ������ �����Ѵٸ� �ش� ��ġ�� ����� ��Ȱ��ȭ ���� 
        
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
