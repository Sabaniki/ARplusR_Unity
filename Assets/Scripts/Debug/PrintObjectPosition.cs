using UnityEngine;
using UnityEngine.UI;

namespace Debug {
    public class PrintObjectPosition : MonoBehaviour {
        // Start is called before the first frame update
        private GameObject TrackingObject;
        public Text PositionText;
        public string TagText;
        void Start() {
            PositionText.text = UpdateRobotPositionText();
        }

        // Update is called once per frame
        void Update() {
            if (TrackingObject == null) {
                TrackingObject = GameObject.FindWithTag(TagText);
                return;
            }
            PositionText.text = UpdateRobotPositionText();
        }

        string UpdateRobotPositionText() {
            if (TrackingObject == null) {
                return $"{TagText} Not Found";
            }
            Vector3 position;
            return $"{TagText}Position(X: {(position = TrackingObject.transform.position).x}, Y: {position.y}, Z: {position.z})";
        }
    }
}