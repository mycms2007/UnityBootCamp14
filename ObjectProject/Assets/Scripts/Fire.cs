using UnityEngine;


//�� �ڵ�� �Ѿ˿� ���� �߻�(����) ��ɸ� ����մϴ�. 
public class Fire : MonoBehaviour
{
    //�� �߻縦 ���� Ǯ
    public BulletPool pool;

    //�߻�����
    public Transform pos;




    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = pool.GetBullet();
            bullet.transform.position = pos.position;
                bullet.transform.rotation = pos.rotation;

        }
    }
}
