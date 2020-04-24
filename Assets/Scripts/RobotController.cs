﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotController : MonoBehaviour {
    // Start is called before the first frame update
    private GameObject VirtualRobot;
    public Text RobotPositionText;
    void Start() {
        VirtualRobot = GameObject.FindWithTag("VirtualRobot");
        RobotPositionText.text = UpdateRobotPositionText();
    }

    // Update is called once per frame
    void Update() {
        if (VirtualRobot == null) {
            VirtualRobot = GameObject.FindWithTag("VirtualRobot");
            return;
        }
        RobotPositionText.text = UpdateRobotPositionText();
    }

    string UpdateRobotPositionText() {
        if (VirtualRobot == null) {
            return "Robot Not Found";
        }
        Vector3 position;
        return $"RobotPosition(X: {(position = VirtualRobot.transform.position).x}, Y: {position.y}, Z: {position.z})";
    }
}