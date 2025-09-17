using UnityEngine;
using Unity.Netcode;

namespace Elements.Crossfire.Test
{

    public class TestNetworkObject : NetworkBehaviour
    {
        public NetworkVariable<int> counter = new NetworkVariable<int>();

        void Update()
        {
            if (IsOwner && Input.GetKeyDown(KeyCode.Space))
            {
                counter.Value++;
                Debug.Log($"[Owner {OwnerClientId}] incremented counter -> {counter.Value}");
            }

            if (IsServer)
            {
                //Debug.Log($"[Server sees] counter={counter.Value}");
            }
        }
    }
}