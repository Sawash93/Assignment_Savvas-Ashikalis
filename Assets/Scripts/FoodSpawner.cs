using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Food[] foodPrefabArray;
    

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        var foodIndex = Random.Range(0, foodPrefabArray.Length);
        Spawn(foodPrefabArray[foodIndex]);
    }
    private void Spawn(Food myFood)
    {
        var spawnPosition = new Vector3(Random.Range(-2, 2), Random.Range(-4, 4), 0f);
        Food newFood = Instantiate
        (myFood, spawnPosition, transform.rotation)
        as Food;
        newFood.transform.parent = transform; //add this as a child to spawner
    }
}