using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputControllerBase : ScriptableObject
{
    public abstract float RetrieveVerticalInput();

    public abstract float RetrieveHorizontalInput();

    public abstract bool RetrieveFiringInput();
}
