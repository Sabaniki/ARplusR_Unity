using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Debug {
    public class PrintObjectPosition : MonoBehaviour {
        // Start is called before the first frame update
        private GameObject[] trackingObjects = {};
        public Text PositionText;
        public string TagText;

        void Start() {
            PositionText.text = UpdateRobotPositionText();
        }

        // Update is called once per frame
        void Update() {
            // if (!trackingObjects.Any()) {
                trackingObjects = GameObject.FindGameObjectsWithTag(TagText);
                // return;
            // }
            PositionText.text = UpdateRobotPositionText();
        }

        string UpdateRobotPositionText() {
            if (!trackingObjects.Any()) {
                return $"{TagText} Not Found";
            }

            var positionText = "";
            foreach (var trackingObject in trackingObjects) {
                Vector3 position;
                positionText += $"{TagText}Position(X: {(position = trackingObject.transform.position).x}, Y: {position.y}, Z: {position.z})\n";
            }

            return positionText;
        }
    }
}