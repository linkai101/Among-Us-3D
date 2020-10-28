using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabMenu : MonoBehaviour { // Add to Canvas object

    public GameObject TabMenuObject;
    public Transform Player;
    public float mapScaleOffset = 5f;

    Transform image; // Character image on tab menu

    private Vector3 originalImagePosition;

    void Start() {
        image = transform.Find("Tab_Menu/Map/Player");

        originalImagePosition = image.localPosition;
    }

    void LateUpdate() {
        if (Input.GetKey(KeyCode.Tab)) {
            if (!TabMenuObject.activeSelf) {
                TabMenuObject.SetActive(true);
            }
        } else {
            if (TabMenuObject.activeSelf) {
                TabMenuObject.SetActive(false);
            }
        }
        
        // TODO: Only update if tab menu is open

        Vector3 newPos = new Vector3(Player.position.x*mapScaleOffset+originalImagePosition.x, Player.position.z*mapScaleOffset+originalImagePosition.y, 0f);
        image.localPosition = newPos;
    }

}
