using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("B�lgeler i�in prefablar")]
    public GameObject prefabA;
    public GameObject prefabB;
    public GameObject prefabC;

    [Header("B�lgelerin pozisyonlar�")]
    public Transform regionAPosition;
    public Transform regionBPosition;
    public Transform regionCPosition;

    [Header("Spawn S�resi i�te")]
    public float spawnInterval = 10f;

    private int lastPrefabIndex = -1; //son spawn edilen obje nosu

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnRandomObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void SpawnRandomObject()
    {
        int newPrefabIndex;

        do
        {
            newPrefabIndex = Random.Range(0, 3);
        } while (newPrefabIndex == lastPrefabIndex);

        lastPrefabIndex = newPrefabIndex;

        switch (newPrefabIndex)
        {
            case 0:
                Instantiate(prefabA, regionAPosition.position, Quaternion.identity);
                Debug.Log("A b�lgesine spawn edildi");
                break;
            case 1:
                Instantiate(prefabB, regionBPosition.position, Quaternion.identity);
                Debug.Log("B b�lgesine spawn edildi");
                break;
            case 2:
                Instantiate(prefabC, regionCPosition.position, Quaternion.identity);
                Debug.Log("C b�lgesine spawn edildi");
                break;
        }
    }
}
