using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HammerConection : MonoBehaviour
{
    public InputActionReference rightPrimaryButton;
    public Hammer hammer;
    // Start is called before the first frame update
    void Start()
    {
        rightPrimaryButton.action.performed += PrimaryButtonPressed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PrimaryButtonPressed(InputAction.CallbackContext context)
    {
        hammer.ReturnHammer();
    }
}
