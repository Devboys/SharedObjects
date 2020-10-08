using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Devboys.SharedObjects
{
    public abstract class ScriptableObjectBase : ScriptableObject
    {
#if UNITY_EDITOR
        //used to describe this scriptable object in the inspector. Never use this for anything.
        [SerializeField] [TextArea] private string description = " - Describe the purpose of this object here - ";
#endif
    }
}
