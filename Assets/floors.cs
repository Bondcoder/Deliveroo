using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floors : MonoBehaviour {

    public Transform floor;
    public int numberOfFloor = 100;
    float currentFloor = 0.0f;
    void Start()
    {
        for (int i = 0; i < numberOfFloor; i++)
        {
          
            if (i == 0)
            {
                Vector3 position = new Vector3(225.5f, currentFloor += 69.6f, 281.7f);
                Instantiate(floor, position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
            }

            if(i > 0)
            {
                Vector3 position = new Vector3(225.5f, currentFloor += 150.9f, 281.7f);
                Instantiate(floor, position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
            }
            Debug.Log(currentFloor);
        }
    }
}
