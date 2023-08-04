datablock TriggerData(GoldenTowerThirdFloorTrigger)
{
	tickPeriodMS = 100;
};

function GoldenTowerThirdFloorTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowGoldenTowerThirdFloor');
	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function GoldenTowerThirdFloorTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowGoldenTowerThirdFloor()
{
	MessageBoxYesNo("", "Are you ready for 3rd Floor?", "GoldenTowerFourthFloorLocation(myPlayer);", "Grow some blals");
}

function GoldenTowerFourthFloorLocation(%obj)
{
	%obj.setTransform("-49.3211 -526.554 333.187 0 0 1 221.14");
	addBob("-72.5625 -502.942 333.191");
	addBob("-73.6141 -550.546 333.192");
	addBob("-25.3662 -550.084 333.193");
	addBob("-25.8174 -502.262 333.192");
	return(%obj);
}
