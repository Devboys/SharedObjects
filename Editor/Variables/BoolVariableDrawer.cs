using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Devboys.SharedObjects.Variables;

namespace Devboys.SharedObjects.EditorObjects 
{
    [CustomPropertyDrawer(typeof(BoolVariable))]
    public class BoolVariableDrawer : SharedVariableDrawerBase<bool>
    {
        public override void DrawPreviewField(Rect position, bool currentVariableValue)
        {
            EditorGUI.Toggle(position, currentVariableValue);
        }
    }
}
