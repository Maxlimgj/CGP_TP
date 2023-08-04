datablock TriggerData(GoldenTowerFourthFloorTrigger)
{
	tickPeriodMS = 100;
};

function GoldenTowerFourthFloorTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowGoldenTowerFourthFloor');
	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function GoldenTowerFourthFloorTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowGoldenTowerThirdFloor()
{
	MessageBoxYesNo("", "Are you ready for 4th Floor?", "GoldenTowerFifthFloorLocation(myPlayer);", "pls la");
}

function GoldenTowerFifthFloorLocation(%obj)
{
	%obj.setTransform("-50.1236 -525.727 395.688 0 0 1 221.14");
	addoni("-49.4492 -551.285 395.695");
	return(%obj);
}
