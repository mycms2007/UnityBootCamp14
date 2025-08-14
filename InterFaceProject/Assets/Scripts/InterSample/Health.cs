using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int maxHP = 10;
    int hp;

    void Awake() => hp = maxHP;

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        Debug.Log($"{name} 피격: -{dmg}, 남은 HP {hp}");
        if (hp <= 0) Destroy(gameObject);
    }
}