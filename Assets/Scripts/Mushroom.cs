using UnityEngine;

public class Mushroom : EnemyBase
{
    public GameObject coinPrefab;
    public float dropOffsetY = 0.2f;

    protected override void SpawnDrop()
    {
        if (coinPrefab != null)
        {
            Vector3 pos = transform.position + Vector3.up * dropOffsetY;
            Instantiate(coinPrefab, pos, Quaternion.identity);
        }
    }
}