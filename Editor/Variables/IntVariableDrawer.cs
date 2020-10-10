using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Devboys.SharedObjects.Variables;

namespace Devboys.SharedObjects.EditorObjects 
{
    [CustomPropertyDrawer(typeof(IntVariable))]
    public class IntVariableDrawer : SharedVariableDrawerBase<int>
    {
        public override void DrawPreviewField(Rect position, int currentVariableValue)
        {
            EditorGUI.IntField(position, currentVariableValue);
        }
    }
}
