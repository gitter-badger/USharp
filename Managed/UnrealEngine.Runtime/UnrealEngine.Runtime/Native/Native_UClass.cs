﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 649 // Field is never assigned

namespace UnrealEngine.Runtime.Native
{
    static class Native_UClass
    {
        public delegate IntPtr Del_Get_ClassConstructor(IntPtr instance);
        public delegate void Del_Set_ClassConstructor(IntPtr instance, IntPtr func);
        public delegate void Del_Call_ClassConstructor(IntPtr instance, IntPtr objectInitializer);
        public delegate void Del_Call_ClassConstructorDirectly(IntPtr classConstructor, IntPtr objectInitializer);
        public delegate IntPtr Del_Get_ClassVTableHelperCtorCaller(IntPtr instance);
        public delegate void Del_Set_ClassVTableHelperCtorCaller(IntPtr instance, IntPtr func);
        public delegate IntPtr Del_Call_ClassVTableHelperCtorCaller(IntPtr instance, IntPtr helper);
        public delegate IntPtr Del_Get_ClassAddReferencedObjects(IntPtr instance);
        public delegate void Del_Set_ClassAddReferencedObjects(IntPtr instance, IntPtr func);
        public delegate void Del_Call_ClassAddReferencedObjects(IntPtr instance, IntPtr inThis, IntPtr collector);
        public delegate EClassFlags Del_Get_ClassFlags(IntPtr instance);
        public delegate void Del_Set_ClassFlags(IntPtr instance, EClassFlags value);
        public delegate EClassCastFlags Del_Get_ClassCastFlags(IntPtr instance);
        public delegate void Del_Set_ClassCastFlags(IntPtr instance, EClassCastFlags value);
        public delegate int Del_Get_ClassUnique(IntPtr instance);
        public delegate void Del_Set_ClassUnique(IntPtr instance, int value);
        public delegate IntPtr Del_Get_ClassWithin(IntPtr instance);
        public delegate void Del_Set_ClassWithin(IntPtr instance, IntPtr value);
        public delegate IntPtr Del_Get_ClassGeneratedBy(IntPtr instance);
        public delegate void Del_Set_ClassGeneratedBy(IntPtr instance, IntPtr value);
        public delegate void Del_Get_ClassConfigName(IntPtr instance, out FName result);
        public delegate void Del_Set_ClassConfigName(IntPtr instance, ref FName value);
        public delegate IntPtr Del_Get_ClassReps(IntPtr instance);
        public delegate void Del_Set_ClassReps(IntPtr instance, IntPtr value);
        public delegate IntPtr Del_Get_NetFields(IntPtr instance);
        public delegate void Del_Set_NetFields(IntPtr instance, IntPtr value);
        public delegate void Del_GetHideFunctions(IntPtr instance, IntPtr outHideFunctions);
        public delegate csbool Del_IsFunctionHidden(IntPtr instance, ref FScriptArray inFunction);
        public delegate void Del_GetAutoExpandCategories(IntPtr instance, IntPtr outAutoExpandCategories);
        public delegate csbool Del_IsAutoExpandCategory(IntPtr instance, ref FScriptArray inCategory);
        public delegate void Del_GetAutoCollapseCategories(IntPtr instance, IntPtr outAutoCollapseCategories);
        public delegate csbool Del_IsAutoCollapseCategory(IntPtr instance, ref FScriptArray inCategory);
        public delegate void Del_GetClassGroupNames(IntPtr instance, IntPtr outClassGroupNames);
        public delegate csbool Del_IsClassGroupName(IntPtr instance, ref FScriptArray inGroupName);
        public delegate void Del_CallAddReferencedObjects(IntPtr instance, IntPtr inThis, IntPtr collector);
        public delegate IntPtr Del_Get_ClassDefaultObject(IntPtr instance);
        public delegate void Del_Set_ClassDefaultObject(IntPtr instance, IntPtr value);
        public delegate csbool Del_Get_bCooked(IntPtr instance);
        public delegate void Del_Set_bCooked(IntPtr instance, csbool value);
        public delegate void Del_Get_Interfaces(IntPtr instance, IntPtr outInterfaces);
        public delegate void Del_Set_Interfaces(IntPtr instance, IntPtr value);
        public delegate IntPtr Del_Get_InterfacesRef(IntPtr instance);
        public delegate void Del_PrependStreamWithSuperClass(IntPtr instance, IntPtr superClass);
        //public delegate IntPtr Del_Get_ReferenceTokenStream(IntPtr instance);
        //public delegate void Del_Set_ReferenceTokenStream(IntPtr instance, IntPtr value);
        //public delegate IntPtr Del_Get_DebugTokenMap(IntPtr instance);
        //public delegate void Del_Set_DebugTokenMap(IntPtr instance, IntPtr value);
        public delegate IntPtr Del_Get_NativeFunctionLookupTable(IntPtr instance);
        public delegate void Del_Set_NativeFunctionLookupTable(IntPtr instance, IntPtr value);
        public delegate csbool Del_ReplaceNativeFunction(IntPtr instance, ref FName inName, IntPtr inPointer, csbool addToFunctionRemapTable);
        public delegate IntPtr Del_GetAuthoritativeClass(IntPtr instance);
        public delegate void Del_AddNativeFunction(IntPtr instance, ref FScriptArray inName, IntPtr inPointer);
        public delegate void Del_AddFunctionToFunctionMap(IntPtr instance, IntPtr function, ref FName funcName);
        public delegate IntPtr Del_FindFunctionByName(IntPtr instance, ref FName inName, csbool includeSuper);
        public delegate void Del_GetConfigName(IntPtr instance, ref FScriptArray result);
        public delegate IntPtr Del_GetSuperClass(IntPtr instance);
        public delegate IntPtr Del_GetDefaultPropertiesFeedbackContext(IntPtr instance);
        public delegate int Del_GetDefaultsCount(IntPtr instance);
        public delegate IntPtr Del_GetDefaultObject(IntPtr instance, csbool createIfNeeded);
        public delegate void Del_GetDefaultObjectName(IntPtr instance, out FName result);
        public delegate IntPtr Del_GetPersistentUberGraphFrame(IntPtr instance, IntPtr obj, IntPtr funcToCheck);
        public delegate void Del_CreatePersistentUberGraphFrame(IntPtr instance, IntPtr obj);
        public delegate void Del_DestroyPersistentUberGraphFrame(IntPtr instance, IntPtr obj);
        public delegate IntPtr Del_GetDefaultSubobjectByName(IntPtr instance, ref FName toFind);
        public delegate void Del_AddDefaultSubobject(IntPtr instance, IntPtr newSubobject, IntPtr baseClass);
        public delegate void Del_GetDefaultObjectSubobjects(IntPtr instance, IntPtr outDefaultSubobjects);
        public delegate csbool Del_HasAnyClassFlags(IntPtr instance, EClassFlags flagsToCheck);
        public delegate csbool Del_HasAllClassFlags(IntPtr instance, EClassFlags flagsToCheck);
        public delegate EClassFlags Del_GetClassFlags(IntPtr instance);
        public delegate csbool Del_HasAnyCastFlag(IntPtr instance, EClassCastFlags flagToCheck);
        public delegate csbool Del_HasAllCastFlags(IntPtr instance, EClassCastFlags flagToCheck);
        public delegate void Del_GetDescription(IntPtr instance, ref FScriptArray result);
        public delegate void Del_EmitObjectReference(IntPtr instance, int offset, ref FName debugName, int kind);
        public delegate void Del_EmitObjectArrayReference(IntPtr instance, int offset, ref FName debugName);
        public delegate void Del_EmitStructArrayBegin(IntPtr instance, int offset, ref FName debugName, int stride);
        public delegate void Del_EmitStructArrayEnd(IntPtr instance, int skipIndexIndex);
        public delegate void Del_EmitFixedArrayBegin(IntPtr instance, int offset, ref FName debugName, int stride, int count);
        public delegate void Del_EmitFixedArrayEnd(IntPtr instance);
        public delegate void Del_AssembleReferenceTokenStream(IntPtr instance, csbool force);
        public delegate csbool Del_ImplementsInterface(IntPtr instance, IntPtr someInterface);
        public delegate void Del_SerializeDefaultObject(IntPtr instance, IntPtr obj, IntPtr ar);
        public delegate void Del_PurgeClass(IntPtr instance, csbool recompilingOnLoad);
        public delegate IntPtr Del_FindCommonBase(IntPtr inClassA, IntPtr inClassB);
        public delegate IntPtr Del_FindCommonBaseMany(IntPtr inClasses);
        public delegate csbool Del_IsFunctionImplementedInBlueprint(IntPtr instance, ref FName inFunctionName);
        public delegate csbool Del_HasProperty(IntPtr instance, IntPtr inProperty);
        
        public static Del_Get_ClassConstructor Get_ClassConstructor;
        public static Del_Set_ClassConstructor Set_ClassConstructor;
        public static Del_Call_ClassConstructor Call_ClassConstructor;
        public static Del_Call_ClassConstructorDirectly Call_ClassConstructorDirectly;
        public static Del_Get_ClassVTableHelperCtorCaller Get_ClassVTableHelperCtorCaller;
        public static Del_Set_ClassVTableHelperCtorCaller Set_ClassVTableHelperCtorCaller;
        public static Del_Call_ClassVTableHelperCtorCaller Call_ClassVTableHelperCtorCaller;
        public static Del_Get_ClassAddReferencedObjects Get_ClassAddReferencedObjects;
        public static Del_Set_ClassAddReferencedObjects Set_ClassAddReferencedObjects;
        public static Del_Call_ClassAddReferencedObjects Call_ClassAddReferencedObjects;
        public static Del_Get_ClassFlags Get_ClassFlags;
        public static Del_Set_ClassFlags Set_ClassFlags;
        public static Del_Get_ClassCastFlags Get_ClassCastFlags;
        public static Del_Set_ClassCastFlags Set_ClassCastFlags;
        public static Del_Get_ClassUnique Get_ClassUnique;
        public static Del_Set_ClassUnique Set_ClassUnique;
        public static Del_Get_ClassWithin Get_ClassWithin;
        public static Del_Set_ClassWithin Set_ClassWithin;
        public static Del_Get_ClassGeneratedBy Get_ClassGeneratedBy;
        public static Del_Set_ClassGeneratedBy Set_ClassGeneratedBy;
        public static Del_Get_ClassConfigName Get_ClassConfigName;
        public static Del_Set_ClassConfigName Set_ClassConfigName;
        public static Del_Get_ClassReps Get_ClassReps;
        public static Del_Set_ClassReps Set_ClassReps;
        public static Del_Get_NetFields Get_NetFields;
        public static Del_Set_NetFields Set_NetFields;
        public static Del_GetHideFunctions GetHideFunctions;
        public static Del_IsFunctionHidden IsFunctionHidden;
        public static Del_GetAutoExpandCategories GetAutoExpandCategories;
        public static Del_IsAutoExpandCategory IsAutoExpandCategory;
        public static Del_GetAutoCollapseCategories GetAutoCollapseCategories;
        public static Del_IsAutoCollapseCategory IsAutoCollapseCategory;
        public static Del_GetClassGroupNames GetClassGroupNames;
        public static Del_IsClassGroupName IsClassGroupName;
        public static Del_CallAddReferencedObjects CallAddReferencedObjects;
        public static Del_Get_ClassDefaultObject Get_ClassDefaultObject;
        public static Del_Set_ClassDefaultObject Set_ClassDefaultObject;
        public static Del_Get_bCooked Get_bCooked;
        public static Del_Set_bCooked Set_bCooked;
        public static Del_Get_Interfaces Get_Interfaces;
        public static Del_Set_Interfaces Set_Interfaces;
        public static Del_Get_InterfacesRef Get_InterfacesRef;
        public static Del_PrependStreamWithSuperClass PrependStreamWithSuperClass;
        //public static Del_Get_ReferenceTokenStream Get_ReferenceTokenStream;
        //public static Del_Set_ReferenceTokenStream Set_ReferenceTokenStream;
        //public static Del_Get_DebugTokenMap Get_DebugTokenMap;
        //public static Del_Set_DebugTokenMap Set_DebugTokenMap;
        public static Del_Get_NativeFunctionLookupTable Get_NativeFunctionLookupTable;
        public static Del_Set_NativeFunctionLookupTable Set_NativeFunctionLookupTable;
        public static Del_ReplaceNativeFunction ReplaceNativeFunction;
        public static Del_GetAuthoritativeClass GetAuthoritativeClass;
        public static Del_AddNativeFunction AddNativeFunction;
        public static Del_AddFunctionToFunctionMap AddFunctionToFunctionMap;
        public static Del_FindFunctionByName FindFunctionByName;
        public static Del_GetConfigName GetConfigName;
        public static Del_GetSuperClass GetSuperClass;
        public static Del_GetDefaultPropertiesFeedbackContext GetDefaultPropertiesFeedbackContext;
        public static Del_GetDefaultsCount GetDefaultsCount;
        public static Del_GetDefaultObject GetDefaultObject;
        public static Del_GetDefaultObjectName GetDefaultObjectName;
        public static Del_GetPersistentUberGraphFrame GetPersistentUberGraphFrame;
        public static Del_CreatePersistentUberGraphFrame CreatePersistentUberGraphFrame;
        public static Del_DestroyPersistentUberGraphFrame DestroyPersistentUberGraphFrame;
        public static Del_GetDefaultSubobjectByName GetDefaultSubobjectByName;
        public static Del_AddDefaultSubobject AddDefaultSubobject;
        public static Del_GetDefaultObjectSubobjects GetDefaultObjectSubobjects;
        public static Del_HasAnyClassFlags HasAnyClassFlags;
        public static Del_HasAllClassFlags HasAllClassFlags;
        public static Del_GetClassFlags GetClassFlags;
        public static Del_HasAnyCastFlag HasAnyCastFlag;
        public static Del_HasAllCastFlags HasAllCastFlags;
        public static Del_GetDescription GetDescription;
        public static Del_EmitObjectReference EmitObjectReference;
        public static Del_EmitObjectArrayReference EmitObjectArrayReference;
        public static Del_EmitStructArrayBegin EmitStructArrayBegin;
        public static Del_EmitStructArrayEnd EmitStructArrayEnd;
        public static Del_EmitFixedArrayBegin EmitFixedArrayBegin;
        public static Del_EmitFixedArrayEnd EmitFixedArrayEnd;
        public static Del_AssembleReferenceTokenStream AssembleReferenceTokenStream;
        public static Del_ImplementsInterface ImplementsInterface;
        public static Del_SerializeDefaultObject SerializeDefaultObject;
        public static Del_PurgeClass PurgeClass;
        public static Del_FindCommonBase FindCommonBase;
        public static Del_FindCommonBaseMany FindCommonBaseMany;
        public static Del_IsFunctionImplementedInBlueprint IsFunctionImplementedInBlueprint;
        public static Del_HasProperty HasProperty;
    }
}
