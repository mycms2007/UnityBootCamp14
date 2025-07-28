using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject ObjectPrefab;

    float spawnTime = 2.0f;
    float time = 0.0f;//시간 체크용 변수
    //시간을 따로 계산해서, 변수로 저장하고
    //그 변수가 스폰 타임보다 커지면 오브젝트 생성
    //변수를 0으로 초기화

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > spawnTime)
        {
            GameObject go = Instantiate(ObjectPrefab);
            time = 0.0f;


        }
    }
}
