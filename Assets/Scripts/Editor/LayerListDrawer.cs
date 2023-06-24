﻿using UnityEditor;
using UnityEngine;

namespace NDP.PlatformGame.Editor
{
    [CustomPropertyDrawer(typeof(LayerListAttribute), true)]
    public class LayerListDrawer : PropertyDrawer
    {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            property.intValue = EditorGUI.LayerField(position, label, property.intValue);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label);
        }
    }
}