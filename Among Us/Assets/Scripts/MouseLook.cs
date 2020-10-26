using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [Header("Mouse Lock")] public bool isMouseLocked = true;
    public float cameraRotateXMin = -90f;
    public float cameraRotateXMax = 90f;

    [Header("Mouse Sensitivity")] public float mouseSensitivity = 4f;
    

    private float m_mouseX;
    private float m_mouseY;
    private float m_rotateX;
    private float m_mouseScrollWheel;
    private Transform m_parent;
    private Camera m_camera;
    private float m_fieldOfView;

    private void Awake()
    {
        m_parent = transform.parent;
        m_camera = Camera.main;
        if (m_camera != null) m_fieldOfView = m_camera.fieldOfView;
        MouseLock();
    }

    private void Update()
    { 
        MouseInput();
        RotatePlayY();
        RotateCameraX();
    }

    private void MouseInput()
    {
        m_mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity;
        m_mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
    }

    private void RotatePlayY()
    {
       m_parent.Rotate(Vector3.up * m_mouseX);
    }

    private void RotateCameraX()
    {
        m_rotateX += m_mouseY;
        m_rotateX = Mathf.Clamp(m_rotateX, cameraRotateXMin, cameraRotateXMax);
        m_camera.transform.localRotation = Quaternion.Euler(-m_rotateX, 0f, 0f);
    }

    private void MouseLock()
    {
        if (isMouseLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            return;
        }
        
        Cursor.lockState = CursorLockMode.None;
    }

}
