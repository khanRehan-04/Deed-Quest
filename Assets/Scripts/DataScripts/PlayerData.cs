using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserData
{
    [System.Serializable]
    public class UserDataTable
    {
        [SerializeField]
        private int _userID;
        public int UserID
        {
            get { return _userID; }
            private set { _userID = value; }
        }
        [SerializeField]
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        [SerializeField]
        private int _starCount;
        public int StarCount
        {
            get { return _starCount; }
            set { _starCount = value; }
        }

        [SerializeField]
        private List<Task> _taskList;
        
        // will be defining default value for new added objects using JSON
        public UserDataTable()
        {
            _userID = 0;
            _userName = string.Empty;
            _starCount = 0;

            _taskList = new List<Task>();
        }

        public void Print()
        {
            Debug.Log($"Username: {_userID}\nStarCount: {StarCount}\nTasks: \n");
            _taskList.ForEach(task => { Debug.Log(task); });
        }
    }
}

