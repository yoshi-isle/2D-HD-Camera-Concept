using System;
using UnityEngine;

public class PlayerGraphics : MonoBehaviour
{
    CameraController cameraController;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite northSprite;
    [SerializeField] private Sprite southSprite;
    [SerializeField] private Sprite eastSprite;
    [SerializeField] private Sprite westSprite;

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
                spriteRenderer.sprite = northSprite;
                break;
            case CameraDirectionHelper.Direction.SOUTH:
                spriteRenderer.sprite = southSprite;
                break;
            case CameraDirectionHelper.Direction.EAST:
                spriteRenderer.sprite = eastSprite;
                break;
            case CameraDirectionHelper.Direction.WEST:
                spriteRenderer.sprite = westSprite;
                break;
        }
    }
}
