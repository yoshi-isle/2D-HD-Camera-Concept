using System;
using UnityEngine;

public class TransformHelper : MonoBehaviour
{
    CameraController cameraController;
    [SerializeField] private Transform transform;
    [SerializeField] private float lookUpPercentage;


    void Start()
    {
        cameraController = Camera.main.GetComponent<CameraController>();
        cameraController.OnRotation90Degrees += HandleCameraRotation;
    }

    private void HandleCameraRotation(CameraDirectionHelper.Direction direction)
    {
        switch (direction)
        {
            case CameraDirectionHelper.Direction.NORTH:
                transform.rotation = Quaternion.Euler(0, 180, 0);
                break;
            case CameraDirectionHelper.Direction.SOUTH:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case CameraDirectionHelper.Direction.EAST:
                transform.rotation = Quaternion.Euler(0, 90, 0);
                break;
            case CameraDirectionHelper.Direction.WEST:
                transform.rotation = Quaternion.Euler(0, 270, 0);
                break;
        }
    }
}
