// Copyright BBAGWANG (GyuTae Hong). All Rights Reserved.

#include "VCharacter.h"


AVCharacter::AVCharacter()
{
	PrimaryActorTick.bCanEverTick = true;

}

void AVCharacter::BeginPlay()
{
	Super::BeginPlay();
	
}

void AVCharacter::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

void AVCharacter::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}
