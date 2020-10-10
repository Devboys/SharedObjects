using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Devboys.SharedObjects.EditorUtils;

namespace Devboys.SharedObjects.Variables
{
    public abstract class SharedNumericVariableBase<T> : ScriptableObjectBase
    {
        [SerializeField] private T _defaultValue;
        [SerializeField][ReadOnly] private T currentValue;

        public T DefaultValue => _defaultValue; //readonly default value

        public T CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        private void OnEnable()
        {
            ResetToDefault();
        }

        public void ResetToDefault()
        {
            currentValue = _defaultValue;
        }
    }
}
