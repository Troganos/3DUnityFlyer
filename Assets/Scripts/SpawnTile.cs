using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour {

    public GameObject l_wall;
    public GameObject r_wall;
    public GameObject ground;
    public int multiplyer = 0;

    public void SpawningTile()
    {
        Debug.Log(multiplyer);
        SpawningAndPlacingObjects(l_wall);
        SpawningAndPlacingObjects(r_wall);
        SpawningAndPlacingObjects(ground);
        transform.Translate(0, 0, 200F);
    }
    private void SpawningAndPlacingObjects(GameObject obj)
    {
       GameObject spawning_obj = (GameObject)Instantiate(obj);
       spawning_obj.transform.position = new Vector3(spawning_obj.transform.position.x, spawning_obj.transform.position.y, spawning_obj.transform.position.z + (200F * multiplyer));
    }
}
