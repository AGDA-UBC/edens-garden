using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour {

    [SerializeField] private Transform m_UIElement;         // The transform of the UI to be affected.
    [SerializeField] private Transform m_Camera;            // The transform of the camera.
    [SerializeField] private float m_FollowSpeed = 10f;     // The speed with which the UI should follow the camera.

    private float m_DistanceFromCamera;                     // The distance the UI should stay from the camera when rotating with it.

    // Use this for initialization
    void Start () {
        m_DistanceFromCamera = Vector3.Distance(m_UIElement.position, m_Camera.position);
    }
	
	// Update is called once per frame
	void Update () {
        m_UIElement.rotation = Quaternion.LookRotation(m_UIElement.position - m_Camera.position);

        Quaternion headRotation = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.Head);
        Vector3 headDirection = headRotation * Vector3.forward;
        Vector3 headDirectionWithDistance = headDirection * m_DistanceFromCamera;
        m_UIElement.position = m_Camera.position + headDirectionWithDistance;
    }
}
