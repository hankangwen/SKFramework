﻿using UnityEngine;

namespace SK.Framework.Actions
{
    [AddComponentMenu("")]
    internal class ActionMaster : MonoBehaviour 
    {
        private static ActionMaster instance;

        internal static ActionMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameObject("[SKFramework.Action]").AddComponent<ActionMaster>();
                    DontDestroyOnLoad(instance);
                }
                return instance;
            }
        }
    }
}