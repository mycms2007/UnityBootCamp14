using UnityEngine;

public class WeaponHitbox : MonoBehaviour
{
    [SerializeField] int damage = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[Hit] {other.name}");

        if (other.TryGetComponent<Health>(out var health))
            health.TakeDamage(damage);

        // ����: ���� �� ������ ��½ (HitFlash �ٿ��� ����)
        if (other.TryGetComponent<HitFlash>(out var flash))
            flash.Flash();
    }
}