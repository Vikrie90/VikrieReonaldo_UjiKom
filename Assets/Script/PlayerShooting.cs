using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
   public GameObject FoodPrefab;
   public Transform SpawnFood;
   public float foodSpeed = 20f;

   void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          var food = Instantiate(FoodPrefab,SpawnFood.position,SpawnFood.rotation);
          food.GetComponent<Rigidbody>().velocity = SpawnFood.forward*foodSpeed;
        }
    }

}
