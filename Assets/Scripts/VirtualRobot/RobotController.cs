using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour {
    private void OnTriggerStay(Collider other) {
        other.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}