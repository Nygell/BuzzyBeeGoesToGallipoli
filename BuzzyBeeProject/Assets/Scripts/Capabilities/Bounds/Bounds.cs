using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bounds : ScriptableObject
{

    public abstract bool InBounds(Rigidbody2D body);
}
