# Unity Netcode Discovery Demo

[See the used Network Discovery code here](https://github.com/Unity-Technologies/multiplayer-community-contributions/tree/main/com.community.netcode.extensions/Runtime/NetworkDiscovery)

## Changes

- In [`NetworkDiscovery.cs`](./Assets/Project/Scripts/Netcode/Discovery/NetworkDiscovery.cs#L207), changed `Allocator.Temp` to `Allocator.TempJob` where the **two** TODO's are.
- In [`ExampleNetworkDiscoveryHud.cs`](./Assets/Project/Scripts/Netcode/Discovery/ExampleNetworkDiscoveryHud.cs#L97), added check if connecting to localhost where the TODO comment is.
