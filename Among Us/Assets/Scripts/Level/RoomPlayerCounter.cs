using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPlayerCounter : MonoBehaviour {

    public GameObject MapDisplay;

    public HashSet<GameObject> players = new HashSet<GameObject>();

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            players.Add(other.gameObject);
            //MapDisplay.GetComponent<AdminMap>().Set(gameObject.name, players.Count);
            MapDisplay.GetComponent<AdminMap>().hasChanged = true;
        }
    }
    
    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            players.Remove(other.gameObject);
            //MapDisplay.GetComponent<AdminMap>().Set(gameObject.name, players.Count);
            MapDisplay.GetComponent<AdminMap>().hasChanged = true;
        }
    }

}
