using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardScore : MonoBehaviour
{
    [SerializeField]
    private float _score;

    private void OnDestroy()
    {
        EventsManager.ChangeScore(_score);
    }
}
