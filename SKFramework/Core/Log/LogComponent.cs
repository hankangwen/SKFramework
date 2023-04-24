using UnityEngine;

namespace SK.Framework.Log
{
    [DisallowMultipleComponent]
    [AddComponentMenu("SKFramework/Log")]
    public class LogComponent : MonoBehaviour
    {
        [SerializeField] private LogWorkingType workingType;
        private bool enableLog;
        
        [SerializeField] private string infoColor = "#00FFFF";
        [SerializeField] private string warningColor = "#FFFF00";
        [SerializeField] private string errorColor = "#FF0000";

        private readonly string format_Info = "<color={0}><b>[SKFramework.Info]</b> {1}</color>";
        private readonly string format_Warning = "<color={0}><b>[SKFramework.Warning]</b></color> {1}";
        private readonly string format_Error = "<color={0}><b>[SKFramework.Error]</b></color> {1}";

        private void Awake()
        {
            switch (workingType)
            {
                case LogWorkingType.AlwaysOpen: enableLog = true; break;
                case LogWorkingType.OnlyOpenWhenDevelopmentBuild: enableLog = Debug.isDebugBuild; break;
                case LogWorkingType.OnlyOpenInEditor: enableLog = Application.isEditor; break;
                case LogWorkingType.AlwaysClose: enableLog = false; break;
            }
        }

        public void Info<T>(T arg)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, arg));
        }
        public void Info<T>(string format, T arg)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg)));
        }
        public void Info<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2)));
        }
        public void Info<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3)));
        }
        public void Info<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4)));
        }
        public void Info<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5)));
        }
        public void Info<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        public void Info<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        public void Info<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)));
        }
        public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)));
        }
        public void Info<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (!enableLog) return;
            Debug.Log(string.Format(format_Info, infoColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)));
        }

        public void Warning<T>(T arg)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, arg));
        }
        public void Warning<T>(string format, T arg)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg)));
        }
        public void Warning<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2)));
        }
        public void Warning<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3)));
        }
        public void Warning<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4)));
        }
        public void Warning<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5)));
        }
        public void Warning<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        public void Warning<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        public void Warning<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)));
        }
        public void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)));
        }
        public void Warning<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (!enableLog) return;
            Debug.LogWarning(string.Format(format_Warning, warningColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)));
        }

        public void Error<T>(T arg)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, arg));
        }
        public void Error<T>(string format, T arg)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg)));
        }
        public void Error<T1, T2>(string format, T1 arg1, T2 arg2)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2)));
        }
        public void Error<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3)));
        }
        public void Error<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4)));
        }
        public void Error<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5)));
        }
        public void Error<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        public void Error<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        public void Error<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)));
        }
        public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)));
        }
        public void Error<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (!enableLog) return;
            Debug.LogError(string.Format(format_Error, errorColor, string.Format(format, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)));
        }
    }
}