datablock TriggerData(GoldenTowerSecondFloorTrigger)
{
	tickPeriodMS = 100;
};

function GoldenTowerSecondFloorTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowGoldenTowerSecondFloor');
	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function GoldenTowerSecondFloorTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowGoldenTowerSecondFloor()
{
	MessageBoxYesNo("", "Are you ready for 2nd Floor?", "GoldenTowerSecondThirdLocation(myPlayer);", "??????");
}

function GoldenTowerThirdFloorLocation(%obj)
{
	%obj.setTransform("-50.0651 -527.106 244.688 0 0 1 196.948");
	addBob("-61.1859 -556.324 244.673");
	addBob("--22.3675 -506.282 244.692");
	addBob("--67.8708 -498.071 244.693");
	return(%obj);
}
