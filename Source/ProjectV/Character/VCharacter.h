// Copyright BBAGWANG (GyuTae Hong). All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "VCharacter.generated.h"


UCLASS()
class PROJECTV_API AVCharacter : public ACharacter
{
	GENERATED_BODY()

public:
	AVCharacter();

protected:
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaTime) override;
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;

};
