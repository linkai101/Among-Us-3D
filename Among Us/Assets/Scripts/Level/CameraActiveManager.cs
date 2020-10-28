using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActiveManager : MonoBehaviour {

    public GameObject Object;
    public Transform Player;

    public float renderDistance = 6f;

    void Update() {
        if (Vector3.Distance(transform.position, Player.position) < renderDistance) {
            if (!Object.activeSelf) {
                Object.SetActive(true);
                gameObject.GetComponent<Renderer>().enabled = true;
                transform.Find("Text").gameObject.SetActive(true);
            }
        } else {
            if (Object.activeSelf) {
                Object.SetActive(false);
                gameObject.GetComponent<Renderer>().enabled = false;
                transform.Find("Text").gameObject.SetActive(false);
            }
        }
    }
}
