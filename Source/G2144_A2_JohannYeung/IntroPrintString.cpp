// Fill out your copyright notice in the Description page of Project Settings.


#include "IntroPrintString.h"

// Sets default values
AIntroPrintString::AIntroPrintString()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AIntroPrintString::BeginPlay()
{
	Super::BeginPlay();
	GEngine->AddOnScreenDebugMessage(-1, 5.0f, FColor::Magenta, "This is Orange.");
}

// Called every frame
void AIntroPrintString::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

