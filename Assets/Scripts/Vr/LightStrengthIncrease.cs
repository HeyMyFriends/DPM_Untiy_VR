/*
This script is used to implement VR interaction(set the light strength to a high value using the controller button).
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightStrengthIncrease : MonoBehaviour
{
    public InputActionReference toggleReference = null;


    private void Awake()
    {
        Shader.SetGlobalFloat("_gLightStrength", 50f);
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
      
        Shader.SetGlobalFloat("_gLightStrength", 50f);

    }

}