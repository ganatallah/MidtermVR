using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonSound : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource
    private bool isPressed = false;  // To track if the button is pressed

    // Detect when the button is pressed
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !isPressed) // Assuming the player's collider has the "Player" tag
        {
            if (Input.GetButtonDown("Fire1"))  // This is for detecting the press action (can be a VR button trigger)
            {
                PlaySound();
                isPressed = true; // Prevent continuous sound playing while pressed
            }
        }
    }

    // Play the sound
    void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play(); // Play the sound
        }
    }

    // Reset button state after a while or when released
    void Update()
    {
        if (isPressed && !Input.GetButton("Fire1"))
        {
            isPressed = false; // Reset the button press when the button is released
        }
    }
}

