using Unity.Netcode;
using UnityEngine;

[RequireComponent(typeof(NetworkObject))]
public class Player : NetworkBehaviour
{
    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            Debug.Log($"{gameObject.name}: spawned");

            float randomX = Random.Range(-10, 10);
            float randomZ = Random.Range(-10, 10);
            transform.position = new Vector3(randomX, .5f, randomZ);
        }
    }

    public override void OnNetworkDespawn()
    {
        if (IsServer)
        {
            Debug.Log($"{gameObject.name}: despawned");
        }
    }
}
