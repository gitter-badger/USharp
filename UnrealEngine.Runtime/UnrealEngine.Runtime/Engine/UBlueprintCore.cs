﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime
{
    [UMetaPath("/Script/Engine.BlueprintCore", "Engine", UnrealModuleType.Engine)]
    public class UBlueprintCore : UObject
    {
        /// <summary>
        /// Pointer to the 'most recent' fully generated class
        /// </summary>        
        public UClass GeneratedClass
        {
            get { return GCHelper.Find<UClass>(Native_UBlueprintCore.Get_GeneratedClass(Address)); }
            set { Native_UBlueprintCore.Set_GeneratedClass(Address, value == null ? IntPtr.Zero : value.Address); }
        }

        /// <summary>
        /// Pointer to the skeleton class; this is regenerated any time a member variable or function is added but  
        /// is usually incomplete (no code or hidden autogenerated variables are added to it)
        /// </summary>
        public UClass SkeletonGeneratedClass
        {
            get { return GCHelper.Find<UClass>(Native_UBlueprintCore.Get_SkeletonGeneratedClass(Address)); }
            set { Native_UBlueprintCore.Set_SkeletonGeneratedClass(Address, value == null ? IntPtr.Zero : value.Address); }
        }
    }
}