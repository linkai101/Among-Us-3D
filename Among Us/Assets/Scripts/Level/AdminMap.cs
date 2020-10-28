using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdminMap : MonoBehaviour {

    public Transform Level;
    public Transform TableTransform;
    public Transform Player;

    public int renderDistance = 8;

    public bool hasChanged = false;

    void Start() {
        foreach (Transform child in transform) {
            child.GetComponent<TextMeshPro>().SetText("");
        }
    }

    void Update() {
        if (Vector3.Distance(TableTransform.position, Player.position) < renderDistance) {
            if (hasChanged) {
                foreach (Transform child in transform) {
                    Set(child.name, Level.Find(child.name).GetComponent<RoomPlayerCounter>().players.Count);
                    hasChanged = false;
                }
            }
        }
    }

    public void Set(string name, int count) {
        if (count == 0) {
            transform.Find(name).GetComponent<TextMeshPro>().SetText("");
        } else {
            transform.Find(name).GetComponent<TextMeshPro>().SetText(count.ToString());
        }
    }
    
}
