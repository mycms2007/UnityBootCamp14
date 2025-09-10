using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyType
    {
        Down, Chase // 아래로 내려가는 패턴, 플레이어를 추적하는 패턴
    }

    public float speed = 5;
    public EnemyType type = EnemyType.Down;

    public GameObject explosionFactory;

    private Vector3 dir;

    private void Start()
    {
        PatternSetting();
    }

    void PatternSetting()
    {
        int rand = Random.Range(0, 10);

        if (rand < 3)
        {
            GameObject target = GameObject.FindGameObjectWithTag("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            type = EnemyType.Chase;
            dir = Vector3.down;
        }
    }

    void Update()
    {
        // 아래로 내려가는 기능
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnDestroy()
    {
        var stage = FindFirstObjectByType<StageManager>();

        if (stage != null)
        {
            stage.ReportEnemyKilled();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager.instance.SetScore(5);
        Instantiate(explosionFactory, transform.position, Quaternion.identity);

        // 🔧 수정 전: 오브젝트를 Destroy() 하면서 하이어라키에서 사라짐
        // Destroy(collision.gameObject); // 상대방(총알) 삭제
        // Destroy(gameObject);           // 나 자신 삭제

        // 🔧 수정 후: SetActive(false) 로 하이어라키에는 남기되 기능 비활성화
        collision.gameObject.SetActive(false); // 총알 비활성화
        gameObject.SetActive(false);           // 적기 비활성화 (하이어라키엔 남음)
    }
}