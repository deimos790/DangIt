﻿
using System;
using UnityEngine;
using System.Diagnostics;

namespace ippo
{
    public static class Logger
    {
        const string MessagePrefix = "DangIt: ";

        [Conditional("DEBUG")]
        public static void Debug(string message)
        {
            UnityEngine.Debug.Log(MessagePrefix + message);
        }
        [ConditionalAttribute("DEBUG")]
        public static void Info(string message)
        {
            UnityEngine.Debug.Log(MessagePrefix + message);
        }

        public static void Error(string message)
        {
            UnityEngine.Debug.LogError(MessagePrefix + message);
        }

        public static void Warn(string message)
        {
            UnityEngine.Debug.LogWarning(MessagePrefix + message);
        }
    }
}

