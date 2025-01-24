using UnityEngine;

public class PlayerGraphics : MonoBehaviour
{
    Transform playerTransform;
    Transform cameraTransform;
    [SerializeField] private float lookUpPercentage;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        Vector3 targetDirection = cameraTransform.position - playerTransform.position;
        targetDirection.y = targetDirection.y * lookUpPercentage;
        if (targetDirection != Vector3.zero)
        {
            playerTransform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }
}
