using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatchActions
{
    public static Action OnMatchStarted = delegate {};
    public static Action<bool> OnMatchPaused = delegate {};
    public static Action OMatchEnded = delegate {};
}
