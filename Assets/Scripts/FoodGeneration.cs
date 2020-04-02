using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{

    public GameObject foodPrefab;
    public GameObject curFood;

    public Vector3 curPosition;

    public float xSize = 8.8f, zSize = 8.8f;
    

    void RandomPosition() {
        curPosition = new Vector3(Random.Range(xSize*-1, xSize), 0.25f, Random.Range(zSize*-1, zSize));
    }

    void AddNewFood() {
        RandomPosition();
        curFood = GameObject.Instantiate(foodPrefab, curPosition, Quaternion.identity) as GameObject;
    }

    void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }

        else {
            return;
        }
    }

}
