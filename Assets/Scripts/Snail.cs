using UnityEngine;

public class Snail : EnemyBase
{

    public GameObject applePrefab;
    public float dropOffsetY = 0.2f;

    protected override void SpawnDrop()
    {
        if (applePrefab != null)
        {
            Vector3 pos = transform.position + Vector3.up * dropOffsetY;
            Instantiate(applePrefab, pos, Quaternion.identity);
        }
    }
}