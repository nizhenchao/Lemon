﻿/**
*   Author：onelei
*   Copyright © 2019 - 2020 ONELEI. All Rights Reserved
*/
using UnityEditor;
using UnityEngine;

namespace Lemon.UI
{
    [CustomEditor(typeof(QImage), true)]
    public class QImageEditor : UnityEditor.UI.ImageEditor
    {
        [MenuItem("GameObject/UI/QImage", false, UtilEditor.Priority_QImage)]
        public static QImage AddComponent()
        {
            QImage component = UtilEditor.ExtensionComponentWhenCreate<QImage>(typeof(QImage).Name.ToString());
            //设置默认值
            SetDefaultValue(component);
            return component;
        }

        QImage component;
        public override void OnInspectorGUI()
        {
            component = (QImage)target;
            base.OnInspectorGUI();
            component.key = EditorGUILayout.TextField("KEY", component.key);
            if (!component.bInit)
            {
                component.bInit = true;
                SetDefaultValue(component);
            }
        }

        private static void SetDefaultValue(QImage component)
        {
            if (component == null)
                return;
            component.raycastTarget = false;
        }
    }
}
