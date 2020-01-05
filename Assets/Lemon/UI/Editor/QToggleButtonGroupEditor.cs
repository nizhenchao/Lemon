﻿/**
*   Author：onelei
*   Copyright © 2019 - 2020 ONELEI. All Rights Reserved
*/
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Lemon.UI
{
    [CustomEditor(typeof(QToggleButtonGroup))]
    public class QToggleButtonGroupEditor : Editor
    {
        [MenuItem("GameObject/UI/QToggleButtonGroup", false, UtilEditor.Priority_QToggleButtonGroup)]
        public static QToggleButtonGroup AddComponent()
        {
            QToggleButtonGroup component = UtilEditor.ExtensionComponentWhenCreate<QToggleButtonGroup>(typeof(QToggleButtonGroup).Name.ToString());
            component.list.Clear();

            for (int i = 0; i < 2; i++)
            {
                Selection.activeObject = component;
                QToggleButton button = QToggleButtonEditor.AddComponent();
                component.list.Add(button);
            }
            Selection.activeObject = component;
            return component;
        }

        QToggleButtonGroup component;
        int index = 0; 
        public override void OnInspectorGUI()
        { 
            component = (QToggleButtonGroup)target;
            GUILayout.BeginHorizontal();
            index = EditorGUILayout.IntField("index", index);
            if (GUILayout.Button("Choose"))
            {
                component.SetToggleGroupEditor(index);
            }
            GUILayout.EndHorizontal();

            base.OnInspectorGUI();
        }
    }
}
 