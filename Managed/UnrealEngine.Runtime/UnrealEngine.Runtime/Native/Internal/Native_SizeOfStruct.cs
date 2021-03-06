﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 649 // Field is never assigned

namespace UnrealEngine.Runtime.Native
{
    static class Native_SizeOfStruct
    {
        public delegate int Del_SizeOf();

        public static Del_SizeOf SizeOf_FSoftObjectPtr;
        public static Del_SizeOf SizeOf_FWeakObjectPtr;
        public static Del_SizeOf SizeOf_FLazyObjectPtr;
        public static Del_SizeOf SizeOf_FSharedPtr;
        public static Del_SizeOf SizeOf_FSharedRef;               
        public static Del_SizeOf SizeOf_FSoftObjectPath;
        public static Del_SizeOf SizeOf_FUniqueObjectGuid;
        public static Del_SizeOf SizeOf_FAssetData;
        public static Del_SizeOf SizeOf_FName;
        public static Del_SizeOf SizeOf_FMinimalName;
        public static Del_SizeOf SizeOf_FScriptName;
        public static Del_SizeOf SizeOf_FScriptDelegate;
        public static Del_SizeOf SizeOf_FMulticastScriptDelegate;
        public static Del_SizeOf SizeOf_FScriptArray;
        public static Del_SizeOf SizeOf_FScriptMap;
        public static Del_SizeOf SizeOf_FScriptMapLayout;
        public static Del_SizeOf SizeOf_FScriptSetLayout;
        public static Del_SizeOf SizeOf_FScriptSparseArrayLayout;
        public static Del_SizeOf SizeOf_FDefaultBitArrayAllocator;
        public static Del_SizeOf SizeOf_FScriptBitArray;
        public static Del_SizeOf SizeOf_FScriptSparseArray;
        public static Del_SizeOf SizeOf_FBitReference;
        public static Del_SizeOf SizeOf_FHashAllocator;
        public static Del_SizeOf SizeOf_FSetElementId;
        public static Del_SizeOf SizeOf_FScriptSet;
        public static Del_SizeOf SizeOf_FImplementedInterfaceInterop;
        public static Del_SizeOf SizeOf_FNativeFunctionLookup;
        public static Del_SizeOf SizeOf_FDelegateHandle;
        public static Del_SizeOf SizeOf_FFrame;
        public static Del_SizeOf SizeOf_TStatId;
    }
}
