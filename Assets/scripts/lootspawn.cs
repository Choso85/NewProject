using UnityEngine;

public class LootSpawn : MonoBehaviour
{
    public GameObject[] lootPrefabs;
    public float dropChance = 0.5f;
    public int minDropCount = 1;
    public int maxDropCount = 3;
    public void SpawnLoot()
    {
        if (Random.value <= dropChance)
        {
            int dropCount = Random.Range(minDropCount, maxDropCount + 1);
            for (int i = 0; i < dropCount; i++)
            {
                GameObject lootPrefab = lootPrefabs[Random.Range(0, lootPrefabs.Length)];
                Instantiate(lootPrefab, transform.position, Quaternion.identity);
            }
        }
        else
        {
            Debug.Log("Loot did not drop.");
        }
    }
}
