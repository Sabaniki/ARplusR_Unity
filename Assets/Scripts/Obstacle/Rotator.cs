using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    void Update() {
        if (Vector3.Distance(GameObject.FindWithTag("VirtualRobot").transform.position, transform.position) < 1.0f) {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}