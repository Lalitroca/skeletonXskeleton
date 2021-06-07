using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configurations : MonoBehaviour
{
    public static Configurations configs;
    public float SoundVolume = 1;
    public int StartingAmmo = 30;
    public float MatchTime = 180;
    public bool EndlessGameMode = false;
    public bool ConstantRunning = false;
    private void Awake()
    {
        if (configs != null && configs != this)
        {
            Destroy(this.gameObject);
        } else {
            configs = this;
            DontDestroyOnLoad(gameObject);
        }

        Cursor.lockState = CursorLockMode.Confined;
        GetSavedConfigs();
    }

    private void GetSavedConfigs()
    {
        if(PlayerPrefs.HasKey("StartingAmmo"))
        {
            StartingAmmo = PlayerPrefs.GetInt("StartingAmmo", StartingAmmo);
        }
        if(PlayerPrefs.HasKey("SoundVolume"))
        {
            SoundVolume = PlayerPrefs.GetFloat("SoundVolume", SoundVolume);
        }
        if(PlayerPrefs.HasKey("MatchTime"))
        {
            MatchTime = PlayerPrefs.GetFloat("MatchTime", MatchTime);
        }
        if(PlayerPrefs.HasKey("ConstantRunning"))
        {
            int ConstantRunningInInt;
            ConstantRunningInInt = PlayerPrefs.GetInt("ConstantRunning", 0);
            if(ConstantRunningInInt == 0)
            {
                ConstantRunning = false;
            } else
            {
                ConstantRunning = true;
            }
        }
        if(PlayerPrefs.HasKey("endlessMode"))
        {
            int endlessInt;
            endlessInt = PlayerPrefs.GetInt("endlessMode", 0);
            if(endlessInt == 0)
            {
                EndlessGameMode = false;
            } else
            {
                EndlessGameMode = true;
            }
        }
    }
    public void Save()
    {
        PlayerPrefs.SetInt("StartingAmmo", StartingAmmo);
        PlayerPrefs.SetFloat("SoundVolume", SoundVolume);
        PlayerPrefs.SetFloat("MatchTime", MatchTime);
        if(ConstantRunning)
        {
            PlayerPrefs.SetInt("ConstantRunning", 1);
        } else
        {
            PlayerPrefs.SetInt("ConstantRunning", 0);
        }
        if(EndlessGameMode)
        {
            PlayerPrefs.SetInt("endlessMode", 1);
        } else
        {
            PlayerPrefs.SetInt("endlessMode", 0);
        }
    }
}
