using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UserData;

namespace DataServices
{
    public class DataStoreManager : MonoBehaviour
    {
        public static DataStoreManager Instance { get; private set; }
        public static bool IsDataLoaded = false;
        private UserDataTable _userData;

        void Awake()
        {
            // will be a singleton class
            if (Instance != null && Instance != this)
                Destroy(this);
            else
            {
                Instance = this;
                _userData = new UserDataTable();
                LoadUserData();
            }
        }

        private void Start()
        {
            // save user data after every 30 seconds
            InvokeRepeating("SaveUserData", 30.0f, 30.0f);
        }

        private void Update()
        {

        }


        public bool LoadUserData()
        {
            string userData = string.Empty;
            // if player data already exists
            if (FileManager.LoadFromFile(out userData))
            {
                Debug.Log($"Loaded UserData: {userData}");
                JsonUtility.FromJsonOverwrite(userData, _userData);
                IsDataLoaded = true;
                return true;
            }

            Debug.Log("User Data not found!, Creating Data");
            SaveUserData();
            IsDataLoaded = false;
            return false;
        }

        public bool SaveUserData()
        {
            Debug.Log($"Sending data to save:"); _userData.Print();
            string saveString = JsonUtility.ToJson(_userData);
            Debug.Log(saveString);
            if (FileManager.WriteToFile(saveString))
                return true;

            return false;
        }
    }
}


