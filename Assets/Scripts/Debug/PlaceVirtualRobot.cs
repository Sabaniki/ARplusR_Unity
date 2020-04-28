using System.Collections;
using System.Collections.Generic;
using Interaction;
using UnityEngine;

public class PlaceVirtualRobot : MonoBehaviour {
    public GameObject interaction;
    public GameObject virtualRobotObject;

    private ARTapToPlaceObject ArTapToPlaceObject;

    // Start is called before the first frame update
    void Start() {
        ArTapToPlaceObject = interaction.GetComponent<ARTapToPlaceObject>();
    }

    // Update is called once per frame
    public void OnClickPlaceVirtualRobotObject() {
        if (ArTapToPlaceObject.placementPoseIsValid) {
            Instantiate(virtualRobotObject, ArTapToPlaceObject.placementPose.position,
                ArTapToPlaceObject.placementPose.rotation);
        }
    }
}