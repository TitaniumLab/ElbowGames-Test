using UnityEngine;

namespace ElbowGames.Rope
{
    [RequireComponent(typeof(LineRenderer))]
    [RequireComponent(typeof(HingeJoint2D))]
    public class RopeRenderer : MonoBehaviour
    {
        private LineRenderer _lineRenderer;
        private HingeJoint2D _joint;

        private void Start()
        {
            _lineRenderer = GetComponent<LineRenderer>();
            _joint = GetComponent<HingeJoint2D>();
            float ropeWidth = transform.localScale.x;
            _lineRenderer.widthMultiplier = ropeWidth;
        }

        private void Update()
        {
            _lineRenderer.SetPosition(0, transform.position);
            _lineRenderer.SetPosition(1, _joint.connectedBody.transform.position);
        }
    }
}
