﻿using UnityEditor;
using UnityEngine;

namespace Unity.ProjectAuditor.Editor.UI
{
    internal static class SharedStyles
    {
        public static GUIStyle Foldout
        {
            get
            {

                if (s_Foldout == null)
                    s_Foldout = new GUIStyle(EditorStyles.foldout)
                    {
                        fontStyle = FontStyle.Bold
                    };
                return s_Foldout;
            }

        }

        public static GUIStyle TextArea
        {
            get
            {
                if (s_TextArea == null)
                    s_TextArea = new GUIStyle(EditorStyles.textArea);
                return s_TextArea;
            }
        }

        public static GUIStyle TextFieldWarning
        {
            get
            {
                if (s_TextFieldWarning == null)
                {
                    s_TextFieldWarning = new GUIStyle(EditorStyles.textField);
                    s_TextFieldWarning.normal.textColor = Color.yellow;
                }

                return s_TextFieldWarning;
            }
        }

        static GUIStyle s_Foldout;
        static GUIStyle s_TextArea;
        static GUIStyle s_TextFieldWarning;
    }

}