using UnityEngine;


[CreateAssetMenu(menuName = "Attack Strategy/Melee")]
public class MelleeAtck : ScriptableObject, IAttackStrategy
{
    public void Attack(GameObject target)
    {
        Debug.Log("[Mellee Attack]" + target.name);
    }
}
