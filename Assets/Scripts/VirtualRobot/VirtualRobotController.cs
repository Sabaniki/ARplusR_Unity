using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VirtualRobotController : MonoBehaviour {
    public float speed;

    void Update() {
        var obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        
        if (!obstacles.Any()) {
            transform.position += transform.forward * (speed * Time.deltaTime);
            return;
        }

        
        foreach (var obstacle in obstacles) {
            if (GetDistanceBetweenVirtualRobotAnd(obstacle) > 1.5f) {
                transform.position += transform.forward * (speed * Time.deltaTime) / obstacles.Length;
            }
            else {
                var leftOrRight = (obstacle.transform.position.x - transform.position.x) > 0 ? -1 : 1;
                while (GetDistanceBetweenVirtualRobotAnd(obstacle) < 1.5f) {
                    transform.position += transform.right * (leftOrRight * (speed * Time.deltaTime)) / obstacles.Length;
                }
            }
        }
    }

    private float GetDistanceBetweenVirtualRobotAnd(GameObject targetObject) =>
        Vector3.Distance(targetObject.transform.position, transform.position);
}