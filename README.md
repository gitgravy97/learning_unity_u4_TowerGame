# Learning Unity -- Tower Ball Game
Demo project to practice Unity

Reference Code Index

`Enemy.cs`
- The `Update()` function has an example of follow-other-object (in this case the player) tracing

`RotateCamera.cs`
- The `Update()` function has an example of horizontal, player-following camera rotation (granted the camera follows the Focal Point in hierarchy)

`SpawnManager.cs`
- `private Vector3 GenerateRandomSpawnPosition()`

`PlayerController.cs`
- The other part of rigging camera rotation to player and focal point is in here
- Examples for OnTriggerEnter and OnCollisionEnter
- Example of using a Coroutine from `System.Collections`
