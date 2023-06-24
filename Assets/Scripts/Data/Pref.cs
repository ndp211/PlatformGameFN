using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NDP.PlatformGame
{
    public static class Pref
    {
        public static bool IsFirstTime
        {
            set => SetBool(GamePref.IsFirstTime.ToString(), value);
            get => GetBool(GamePref.IsFirstTime.ToString(), true);
        }

        public static string GameData
        {
            set => PlayerPrefs.SetString(GamePref.GameData.ToString(), value);
            get => PlayerPrefs.GetString(GamePref.GameData.ToString());
        }

        public static void SetBool(string key, bool isOn)
        {
            if (isOn)
            {
                PlayerPrefs.SetInt(key, 1);
            }
            else
            {
                PlayerPrefs.SetInt(key, 0);
            }
        }

        public static bool GetBool(string key, bool defaultVal = false)
        {
            return PlayerPrefs.HasKey(key) ?
                PlayerPrefs.GetInt(key) == 1 ? true : false
                : defaultVal;
        }
    }
}