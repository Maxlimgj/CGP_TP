datablock TriggerData(GoldenTowerEntranceTrigger)
{
	tickPeriodMS = 100;
};

function GoldenTowerEntranceTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowGoldenTowerEnter');
	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function GoldenTowerEntranceTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}
function clientCmdShowGoldenTowerEnter()
{
	MessageBoxYesNo("", "Welcome to the Golden Tower. Are you ready?", "GoldenTowerFirstFloorLocation(myPlayer);", "Coward");
}

function GoldenTowerFirstFloorLocation(%obj)
{
	%obj.setTransform("-49.4386 -526.288 170.69 0 0 1 225.563");
	addBob("-81.2347 -513.236 170.693");
	addBob("-62.8877 -494.74 170.695");
	addBob("-49.9173 -491.922 170.684");
	addHealthPatch("-48.8854 -500.049 170.693");
	addHealthPatch("-38.6464 -502.518 170.693");
	addHealthPatch("-59.9768 -501.232 170.693");

	addoni("-73.3808 -502.63 170.697");
	return(%obj);
}
