CSEXPORT UWorld* CSCONV Export_UWorld_Get_GWorld()
{
	return GWorld;
}

CSEXPORT const TArray<ULevel*>& CSCONV Export_UWorld_GetLevels(UWorld* instance)
{
	return instance->GetLevels();
}

CSEXPORT UGameInstance* CSCONV Export_UWorld_GetGameInstance(UWorld* instance)
{
	return instance->GetGameInstance();
}

CSEXPORT FTimerManager& CSCONV Export_UWorld_GetTimerManager(UWorld* instance)
{
	return instance->GetTimerManager();
}

CSEXPORT void CSCONV Export_UWorld(RegisterFunc registerFunc)
{
	REGISTER_FUNC(Export_UWorld_Get_GWorld);
	REGISTER_FUNC(Export_UWorld_GetLevels);
	REGISTER_FUNC(Export_UWorld_GetGameInstance);
	REGISTER_FUNC(Export_UWorld_GetTimerManager);
}