using UnityEngine;

public class WeaponHitbox : MonoBehaviour
{
    [SerializeField] int damage = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[Hit] {other.name}");

        if (other.TryGetComponent<Health>(out var health))
            health.TakeDamage(damage);

        // 선택: 맞을 때 빨간색 번쩍 (HitFlash 붙였을 때만)
        if (other.TryGetComponent<HitFlash>(out var flash))
            flash.Flash();
    }
}