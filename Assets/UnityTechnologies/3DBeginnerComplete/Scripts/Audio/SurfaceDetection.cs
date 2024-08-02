using UnityEngine;

public class SurfaceDetection : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponentInParent<PlayerMovement>();
    }
    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = Vector3.down;
        float maxDistance = 100;

        if(Physics.Raycast(origin, direction, out RaycastHit hit, maxDistance))
        {
            if (hit.collider.CompareTag("Wood"))
            {
                playerMovement.surfaceID = 0;
            }
            if (hit.collider.CompareTag("Bathroom"))
            {
                playerMovement.surfaceID = 1;
            }
        }
    }
}
