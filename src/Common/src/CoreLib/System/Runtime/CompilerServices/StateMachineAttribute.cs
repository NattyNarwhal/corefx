// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
#if MONO
    [System.SerializableAttribute]
#endif
    public class StateMachineAttribute : Attribute
    {
        public StateMachineAttribute(Type stateMachineType)
        {
            StateMachineType = stateMachineType;
        }

        public Type StateMachineType { get; }
    }
}
