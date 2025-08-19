using UnityEngine;

public class StageManager : MonoBehaviour
{
    public int targetKills = 20;
    private int currentKills = 0;

    public EnemyManager enemyManager; 
    public GameObject clearMessageUI; 

    public void ReportEnemyKilled()
    {
        currentKills++;

        if (currentKills >= targetKills)
        {
            enemyManager.enabled = false; 
            clearMessageUI.SetActive(true); 
        }
    }
}