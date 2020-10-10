using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Devboys.SharedObjects.Variables;

namespace Devboys.SharedObjects.EditorObjects
{

    [CustomPropertyDrawer(typeof(FloatVariable))]
    public class FloatVariableDrawer : SharedVariableDrawerBase<float>
    {
        public override void DrawPreviewField(Rect position, float currentVariableValue)
        {
            EditorGUI.FloatField(position, currentVariableValue);
        }
    }
}
