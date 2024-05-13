using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public delegate void UpdateScore(float score);

    public static event UpdateScore OnScoreChange;

    public static void ChangeScore(float score)
    {
        OnScoreChange(score);
    }
}
