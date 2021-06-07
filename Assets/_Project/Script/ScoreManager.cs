using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _maxScore;

    public ScoreManager Initialize()
    {
        _maxScore = PlayerPrefs.GetInt("maxScore", 0);
        MatchActions.OnMatchStarted += StartMatch;
        MatchActions.OMatchEnded += EndMatch;

        return this;
    }

    public void GetPoint(int point = 1)
    {
        Score += point;
    }
    public void UpKillCount()
    {
        Kills ++;
    }
    public void UpDeathCount()
    {
        Deaths ++;
    }

    private void OnDestroy()
    {
        MatchActions.OnMatchStarted -= StartMatch;
        MatchActions.OMatchEnded -= EndMatch;
    }
    private void StartMatch()
    {
        Score = 0;
        Deaths = 0;
        Kills = 0;
    }

    private void EndMatch()
    {
        if(Score > _maxScore)
        {
            Score = _maxScore;
            PlayerPrefs.SetInt("maxScore", _maxScore);
        }
    }

    public int Score {get; private set;}
    public int Deaths {get; private set;}
    public int Kills {get; private set;}

}
