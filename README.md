# Unity Netcode Discovery Demo

Code used for network discovery:  
[https://github.com/Unity-Technologies/multiplayer-community-contributions/tree/main/com.community.netcode.extensions/Runtime/NetworkDiscovery](https://github.com/Unity-Technologies/multiplayer-community-contributions/tree/main/com.community.netcode.extensions/Runtime/NetworkDiscovery)

## Changes

- In `NetworkDiscovery.cs`, changed `Allocator.Temp` to `Allocator.TempJob` where the two TODO's are.
- In `ExampleNetworkDiscoveryHud.cs`, added check if connecting to localhost where the TODO comment is.
