using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerRenderer playerRenderer;
    public PlayerMovement playerMovement;
    public PlayerAIInteractions playerAIInteractions;
    public IMovementInput movementInput;
    public PlayerAnimations playerAnimations;


    public UiController uiController;

    private void Start()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
        playerMovement = GetComponent<PlayerMovement>();
        playerRenderer = GetComponent<PlayerRenderer>();
        playerAIInteractions = GetComponent<PlayerAIInteractions>();
        movementInput = GetComponent<IMovementInput>();
        movementInput.OnInteractEvent += () => playerAIInteractions.Interact(playerRenderer.IsSpriteFlipped);
    }
    private void FixedUpdate()
    {
        playerMovement.MovePlayer(movementInput.MovementInputVector);
        playerRenderer.RendererPlayer(movementInput.MovementInputVector);
        playerAnimations.SetupAnimations(movementInput.MovementInputVector);

        if (movementInput.MovementInputVector.magnitude > 0)
        {
            uiController.ToggleUI(false);
        }
    }
    public void ReceiveDamaged()
    {
        playerRenderer.FlashRed();
    }

   
}
