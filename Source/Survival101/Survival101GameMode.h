// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "Survival101GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class ASurvival101GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	ASurvival101GameMode();
};



