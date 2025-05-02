using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerJoiner : MonoBehaviour
{
    private PlayerInputManager _inputManager;

    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    
    private void Awake()
    {
        
        _inputManager = GetComponent<PlayerInputManager>();
        
        Instantiate(playerPrefab2, spawnPoint2.position, spawnPoint2.rotation);
        Instantiate(playerPrefab1, spawnPoint1.position, spawnPoint1.rotation);

        
    }
    

    public void PlayerJoined(PlayerInput input)
    {
        Component inputComponent = input as Component;
        int index = inputComponent.gameObject.GetComponent<PlayerMover>().PlayerIndex;
        
        Debug.Log($"Joining player {index}");
    }
}
