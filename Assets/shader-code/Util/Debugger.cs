﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AndrewBox.Util
{
    public static class Debugger
    {
        public static void LogAtFrame(string infor)
        {
            Debug.Log("["+Time.frameCount+"]"+infor);
        }
        public static void Log(string infor)
        {
            Debug.Log(infor);
        }
        public static void LogWarning(string infor)
        {
            Debug.LogWarning(infor);
        }
        public static void LogError(string infor)
        {
            Debug.LogError(infor);
        }
    }
}