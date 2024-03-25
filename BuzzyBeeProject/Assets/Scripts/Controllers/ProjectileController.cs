using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileControllers", menuName = "ProjectileControllers/BaseProjectileMovement")]
public class ProjectileController : InputControllerBase
{
    public override bool RetrieveFiringInput()
    {
        return false;
    }

    public override float RetrieveHorizontalInput()
    {
        return 0;
    }

    public override float RetrieveVerticalInput()
    {
        return 1f;
    }
}
