﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 649 // Field is never assigned

namespace UnrealEngine.Runtime.Native
{
    static class Native_FApp
    {
        public delegate void Del_GetBranchName(ref FScriptArray result);
        public delegate EBuildConfiguration Del_GetBuildConfiguration();
        public delegate csbool Del_IsRunningDebug();
        public delegate void Del_GetBuildVersion(ref FScriptArray result);
        public delegate void Del_GetDeploymentName(ref FScriptArray result);
        public delegate void Del_GetBuildDate(ref FScriptArray result);
        public delegate csbool Del_GetEngineIsPromotedBuild();
        public delegate void Del_GetEpicProductIdentifier(ref FScriptArray result);
        public delegate void Del_GetProjectName(ref FScriptArray result);
        public delegate void Del_GetName(ref FScriptArray result);
        public delegate csbool Del_HasProjectName();
        public delegate csbool Del_IsGame();
        public delegate csbool Del_IsProjectNameEmpty();
        public delegate void Del_SetProjectName(ref FScriptArray projectName);
        public delegate void Del_AuthorizeUser(ref FScriptArray userName);
        public delegate void Del_DenyAllUsers();
        public delegate void Del_DenyUser(ref FScriptArray userName);
        public delegate void Del_GetInstanceId(out Guid result);
        public delegate void Del_GetInstanceName(ref FScriptArray result);
        public delegate void Del_GetSessionId(out Guid result);
        public delegate void Del_GetSessionName(ref FScriptArray result);
        public delegate void Del_GetSessionOwner(ref FScriptArray result);
        public delegate void Del_InitializeSession();
        public delegate csbool Del_IsAuthorizedUser(ref FScriptArray userName);
        public delegate csbool Del_IsStandalone();
        public delegate csbool Del_IsThisInstance(ref Guid instanceId);
        public delegate void Del_SetSessionName(ref FScriptArray newName);
        public delegate void Del_SetSessionOwner(ref FScriptArray newOwner);
        public delegate csbool Del_CanEverRender();
        public delegate csbool Del_IsInstalled();
        public delegate csbool Del_IsEngineInstalled();
        public delegate csbool Del_IsUnattended();
        public delegate csbool Del_ShouldUseThreadingForPerformance();
        public delegate csbool Del_IsBenchmarking();
        public delegate void Del_SetBenchmarking(csbool val);
        public delegate double Del_GetFixedDeltaTime();
        public delegate void Del_SetFixedDeltaTime(double seconds);
        public delegate csbool Del_UseFixedTimeStep();
        public delegate void Del_SetUseFixedTimeStep(csbool val);
        public delegate double Del_GetCurrentTime();
        public delegate void Del_SetCurrentTime(double seconds);
        public delegate double Del_GetLastTime();
        public delegate void Del_UpdateLastTime();
        public delegate double Del_GetDeltaTime();
        public delegate void Del_SetDeltaTime(double seconds);
        public delegate double Del_GetIdleTime();
        public delegate void Del_SetIdleTime(double seconds);
        public delegate float Del_GetVolumeMultiplier();
        public delegate void Del_SetVolumeMultiplier(float volumeMultiplier);
        public delegate float Del_GetUnfocusedVolumeMultiplier();
        public delegate void Del_SetUnfocusedVolumeMultiplier(float volumeMultiplier);
        public delegate void Del_SetUseVRFocus(csbool useVRFocus);
        public delegate csbool Del_UseVRFocus();
        public delegate void Del_SetHasVRFocus(csbool hasVRFocus);
        public delegate csbool Del_HasVRFocus();
        public delegate csbool Del_Get_UseFixedSeed();
        public delegate void Del_Set_UseFixedSeed(csbool value);

        public static Del_GetBranchName GetBranchName;
        public static Del_GetBuildConfiguration GetBuildConfiguration;
        public static Del_IsRunningDebug IsRunningDebug;
        public static Del_GetBuildVersion GetBuildVersion;
        public static Del_GetDeploymentName GetDeploymentName;
        public static Del_GetBuildDate GetBuildDate;
        public static Del_GetEngineIsPromotedBuild GetEngineIsPromotedBuild;
        public static Del_GetEpicProductIdentifier GetEpicProductIdentifier;
        public static Del_GetProjectName GetProjectName;
        public static Del_GetName GetName;
        public static Del_HasProjectName HasProjectName;
        public static Del_IsGame IsGame;
        public static Del_IsProjectNameEmpty IsProjectNameEmpty;
        public static Del_SetProjectName SetProjectName;
        public static Del_AuthorizeUser AuthorizeUser;
        public static Del_DenyAllUsers DenyAllUsers;
        public static Del_DenyUser DenyUser;
        public static Del_GetInstanceId GetInstanceId;
        public static Del_GetInstanceName GetInstanceName;
        public static Del_GetSessionId GetSessionId;
        public static Del_GetSessionName GetSessionName;
        public static Del_GetSessionOwner GetSessionOwner;
        public static Del_InitializeSession InitializeSession;
        public static Del_IsAuthorizedUser IsAuthorizedUser;
        public static Del_IsStandalone IsStandalone;
        public static Del_IsThisInstance IsThisInstance;
        public static Del_SetSessionName SetSessionName;
        public static Del_SetSessionOwner SetSessionOwner;
        public static Del_CanEverRender CanEverRender;
        public static Del_IsInstalled IsInstalled;
        public static Del_IsEngineInstalled IsEngineInstalled;
        public static Del_IsUnattended IsUnattended;
        public static Del_ShouldUseThreadingForPerformance ShouldUseThreadingForPerformance;
        public static Del_IsBenchmarking IsBenchmarking;
        public static Del_SetBenchmarking SetBenchmarking;
        public static Del_GetFixedDeltaTime GetFixedDeltaTime;
        public static Del_SetFixedDeltaTime SetFixedDeltaTime;
        public static Del_UseFixedTimeStep UseFixedTimeStep;
        public static Del_SetUseFixedTimeStep SetUseFixedTimeStep;
        public static Del_GetCurrentTime GetCurrentTime;
        public static Del_SetCurrentTime SetCurrentTime;
        public static Del_GetLastTime GetLastTime;
        public static Del_UpdateLastTime UpdateLastTime;
        public static Del_GetDeltaTime GetDeltaTime;
        public static Del_SetDeltaTime SetDeltaTime;
        public static Del_GetIdleTime GetIdleTime;
        public static Del_SetIdleTime SetIdleTime;
        public static Del_GetVolumeMultiplier GetVolumeMultiplier;
        public static Del_SetVolumeMultiplier SetVolumeMultiplier;
        public static Del_GetUnfocusedVolumeMultiplier GetUnfocusedVolumeMultiplier;
        public static Del_SetUnfocusedVolumeMultiplier SetUnfocusedVolumeMultiplier;
        public static Del_SetUseVRFocus SetUseVRFocus;
        public static Del_UseVRFocus UseVRFocus;
        public static Del_SetHasVRFocus SetHasVRFocus;
        public static Del_HasVRFocus HasVRFocus;
        public static Del_Get_UseFixedSeed Get_UseFixedSeed;
        public static Del_Set_UseFixedSeed Set_UseFixedSeed;
    }
}
