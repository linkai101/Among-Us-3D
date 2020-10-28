using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    public Transform Player;
    public float mapScaleOffset = 2.5f;
    
    Transform map;

    private Vector3 originalMapPosition;

    void Start() {
        map = transform.Find("Mask/Map");

        originalMapPosition = map.localPosition;
    }


    void LateUpdate() {
        Vector3 newPos = new Vector3(-Player.position.x*mapScaleOffset+originalMapPosition.x, -Player.position.z*mapScaleOffset+originalMapPosition.y, 0f);
        map.localPosition = newPos;

        transform.Find("Mask").GetComponent<RectTransform>().rotation = Quaternion.Euler(0f,0f,Player.eulerAngles.y);
    }

}
