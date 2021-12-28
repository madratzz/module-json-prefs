using System.Collections.Generic;
using UnityEngine;

namespace Core.Modules.JsonPrefs.Scripts
{
    public static class JsonPrefs<T>
    {
        private static Dictionary<string, T> _JsonPrefs = new Dictionary<string, T>();

        public static void SetInt(string key, int value)
        {

        }

        public static int GetInt(string key, int defaultValue)
        {
            return 0;
        }

        public static void SetFloat(string key, float value)
        {

        }

        public static float GetFloat(string key, float defaultValue)
        {
            return 0;
        }

        public static void SetString(string key, string value)
        {

        }

        public static string GetString(string key, string defaultValue)
        {
            return null;
        }

        public static void SetBool(string key, bool value)
        {

        }

        public static bool GetBool(string key, bool defaultValue)
        {
            return false;
        }

        public static void SetVector3(string key, Vector3 value)
        {

        }

        public static Vector3 GetIntVector3(string key, Vector3 defaultValue)
        {
            return Vector3.zero;
        }

        
        public static void DeleteAllPrefs()
        {

        }

        public static void DeleteKey(string key)
        {

        }

        public static bool HasKey(string key)
        {
            //TODO: Check and return desired key
            return false;
        }
    }
}
