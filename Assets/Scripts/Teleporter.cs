using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform exitPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = exitPoint.position;
        }
    }
}
