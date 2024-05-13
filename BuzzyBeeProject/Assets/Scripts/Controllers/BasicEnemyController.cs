using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicEnemyController", menuName = "InputController/BasicEnemyController")]
public class BasicEnemyController : InputControllerBase
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
        return -1;
    }
}
