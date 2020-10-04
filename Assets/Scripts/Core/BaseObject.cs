using UnityEngine;
using SelfishCoder.BaseProject.Interfaces;

namespace SelfishCoder.BaseProject.Base
{
    /// <summary>
    /// 
    /// </summary>
    [DisallowMultipleComponent]
    public class BaseObject : MonoBehaviour, IInitializable, IDestroyable
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectAwake() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectStart() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectOnDisable() { }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BaseObjectDestroy() { }
    }
}