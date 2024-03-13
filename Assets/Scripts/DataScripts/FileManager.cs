using System;
using System.IO;
using UnityEngine;

namespace DataServices
{
    public static class FileManager
    {
        private static string _FILEPATH = Path.Combine(Application.persistentDataPath, "PlayerData(1)");

        public static bool LoadFromFile(out string playerData)
        {
            try
            {
                playerData = File.ReadAllText(_FILEPATH);
                return true;
            }
            catch (Exception e)
            {
                playerData = "";
                Debug.Log($"Error while reading player data. Exception {e}");
                return false;
            }
        }

        public static bool WriteToFile(string playerData)
        {
            try
            {
                File.WriteAllText(_FILEPATH, playerData);
                return true;
            }
            catch (Exception e)
            {
                Debug.Log($"Error while saving player data. Data: {playerData}. Exception {e}");
                return false;
            }
        }
    }
}


