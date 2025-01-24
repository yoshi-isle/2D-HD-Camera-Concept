using UnityEngine;

public class CompassHandController : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (cameraController != null)
        {
            float cameraAngle = cameraController.transform.eulerAngles.y;
            rectTransform.rotation = Quaternion.Euler(0, 0, -cameraAngle);
        }
    }
}
