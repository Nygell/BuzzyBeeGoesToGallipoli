using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerBounds", menuName = "Bounds/PlayerBounds")]
public class PlayerBounds : Bounds
{
    private Camera _cam;
    public override bool InBounds(Rigidbody2D body)
    {
        return _cam.WorldToViewportPoint(body.position).x is >= 0f and <= 1f;
    }

    private void Awake()
    {
        _cam = Camera.main;
    }
}
