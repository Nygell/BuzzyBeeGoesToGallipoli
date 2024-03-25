using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
public class PlayerController : InputControllerBase
{
    public override bool RetrieveFiringInput()
    {
        return true;
    }

    public override float RetrieveHorizontalInput()
    {
        return Input.GetAxis("Horizontal");
    }

    public override float RetrieveVerticalInput()
    {
        return Input.GetAxis("Vertical");
    }
}
