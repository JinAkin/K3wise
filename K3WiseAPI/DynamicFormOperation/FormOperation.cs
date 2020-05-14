﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 表单操作抽象类，调用操作需要指定具体的业务对象ID。
    /// </summary>
    public abstract class FormOperation : APIOperation
    {
        #region 公共属性

        /// <summary>
        /// 读写动态表单类型标识属性值。
        /// </summary>
        public virtual string ObjectTypeId { get; set; }//end property

        #endregion

        #region 公共方法

        /// <summary>
        /// 设置读写动态表单类型标识。
        /// </summary>
        /// <typeparam name="T">继承APIOperation的类。</typeparam>
        /// <param name="objectTypeId">动态表单类型标识。</param>
        /// <returns>返回T定义类型的实例对象。</returns>
        public virtual T SetObjectTypeId<T>(string objectTypeId) where T : APIOperation
        {
            this.ObjectTypeId = objectTypeId;
            return this as T;
        }//end method

        #endregion
    }
}
