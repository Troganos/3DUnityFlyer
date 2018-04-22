using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTileTrigger : MonoBehaviour {

    public BoxCollider bc;
    public SpawnTile st;

    void OnTriggerEnter(Collider other)
    {
        // If other collider is the player
        if (other.name == "Player")
        {
            st.multiplyer = st.multiplyer + 1;
            st.SpawningTile();
        }
    }
}
