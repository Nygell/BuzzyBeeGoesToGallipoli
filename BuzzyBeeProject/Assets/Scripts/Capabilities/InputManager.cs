using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputControllerBase _controller;
    [SerializeField]
    private Bounds _bounds;

    public InputControllerBase Controller
    {
        get { return _controller; }
    }

    public Bounds Bounds
    {
        get { return _bounds; }
    }
}
