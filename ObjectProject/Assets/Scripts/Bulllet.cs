using System.Collections;
using UnityEngine;

//�Ѿ˿� ���� ����, �Ѿ� �ݳ�, �Ѿ� �̵�
public class Bullet : MonoBehaviour
{
    public float speed = 5.0f; //�Ѿ� �̵� �ӵ�
    public float life_time = 2.0f; //�Ѿ� �ݳ� �ð�
    public GameObject effect_prefab; //����Ʈ ������

    private BulletPool pool; //Ǯ
    private Coroutine life_coroutine;

    public void SetPool(BulletPool pool)
    {
        this.pool = pool;
    }

    //Ȱ��ȭ �ܰ�

    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulletReturn());

    }

    //��Ȱ��ȭ �ܰ�
    private void OnDisable()
    {
        //if�� �ۼ� �� ��ɹ��� 1���� ��� {}���� �����մϴ�.
        if(life_coroutine != null)
            StopCoroutine(life_coroutine);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    IEnumerator BulletReturn()
    {
        yield return new WaitForSeconds(life_time);
        pool.Return(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        //�ε��� ����� Enemy �±׸� ������ �ִ� ������Ʈ�ϰ�� �������� �����ϴ�. �� ���� ������ ���� �ڵ� �ۼ�
        //����Ʈ����(��ƼŬ)
        if(effect_prefab != null)
            Instantiate(effect_prefab, transform.position, Quaternion.identity);

        ReturnPool();
        pool.Return(gameObject);

    }

    //�޼ҵ��� ����� 1���� ���, => �� ����� �� �ֽ��ϴ�.
    void ReturnPool() => pool.Return(gameObject);

}
