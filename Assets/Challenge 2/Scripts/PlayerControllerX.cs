using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int spawnTimer = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnTimer == 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                spawnTimer++;
            }
            else if (spawnTimer == 5)
            {
                spawnTimer = 0;
            }
            else
            {
                spawnTimer++;
            }
        }
    }
}
