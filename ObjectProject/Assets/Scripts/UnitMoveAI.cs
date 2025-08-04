using System.Collections;
using UnityEngine;

public class UnitMoveAI : MonoBehaviour
{
    public float speed = 2.0f; //이동속도
    public float detection = 5.0f; //검색 범위

    private Transform player_position; //플레이어 위치

    // Update is called once per frame
    void Start()
    {
        player_position = GameObject.FindGameObjectWithTag("Player")?.transform;
        //(? 연산자 활용) : 객체가 null일 때 발생할 오류 방지
        //GameObject.FindGameObjectWithTag("Player").transform와 같이 작성을 하면
        //해당 값을 Nullable 타입으로 변경합니다.

        if (player_position != null)
        {
            StartCoroutine(Move());
        }
        else
        {
            Debug.LogWarning("게임 내에서 플레이어를 찾을 수 없습니다.");
        }
    }

    IEnumerator Move()
    {
        while (player_position != null)
        {
            float distance = Vector3.Distance(transform.position, player_position.position);


            //플레이어가 지정된 거리 내에 있다면?
            if(distance <=detection)
            {
                Vector3 dir = (player_position.position - transform.position).normalized;

                transform.position = Vector3.MoveTowards(transform.position, player_position.position, speed * Time.deltaTime);


            }

            else
            {

            }
            yield return null;
        }
    }
}
