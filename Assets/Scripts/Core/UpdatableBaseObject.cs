using UnityEngine;
using SelfishCoder.BaseProject.Interfaces;

namespace SelfishCoder.BaseProject.Base
{
    /// <summary>
    /// 
    /// </summary>
    [DisallowMultipleComponent]
    public class UpdatableBaseObject : BaseObject, IUpdatable
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectUpdate() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectFixedUpdate() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectLateUpdate() { }
    }
}