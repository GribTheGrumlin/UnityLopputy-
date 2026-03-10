using UnityEngine;

public class trigger : MonoBehaviour
{
    public Transform player;
    public Transform teleportDestination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            player.position = teleportDestination.position;
        }
    }
}
