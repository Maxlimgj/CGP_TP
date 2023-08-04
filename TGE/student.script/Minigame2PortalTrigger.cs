datablock TriggerData(Minigame2PortalTrigger)
{
	tickPeriodMS = 100;
};

function Minigame2PortalTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowMinigame2Start');
	exec("student.script/animateBalls.cs");
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function Minigame2PortalTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowMinigame2Start()
{
	MessageBoxYesNo("", "Welcome. Do you want to play a game? (Play to get clues on the maze)", "Minigame2Location(myPlayer);", "");
}

function Minigame2Location(%obj)
{
	%obj.setTransform("-89.1799 -470.41 -119.378 0 0 1 186.116");
	MessageBoxOK("", "You have 300s");
	startTimer(300);
	addBob2("-106.341 -338.309 -119.366");//right bob2
	addBob2("-106.341 -344.672 -119.38");
	addBob2("-106.341 -351.035 -119.38");
	addBob2("-106.341 -357.398 -119.38");
	addBob2("-106.341 -363.761 -119.38");
	addBob2("-106.341 -370.124 -119.38");
	addBob2("-106.341 -376.487 -119.38");
	addBob2("-106.341 -382.85 -119.38");
	addBob2("-106.341 -389.213 -119.38");
	addBob2("-106.341 -395.576 -119.38");
	addBob2("-106.341 -401.939 -119.38");
	addBob2("-106.341 -408.302 -119.38");
	addBob2("-106.341 -414.665 -119.38");

	addBob2("-73.3279 -338.309 -119.366");//left bob2
	addBob2("-73.3279 -344.672 -119.38");
	addBob2("-73.3279 -351.035 -119.38");
	addBob2("-73.3279 -357.398 -119.38");
	addBob2("-73.3279 -363.761 -119.38");
	addBob2("-73.3279 -370.124 -119.38");
	addBob2("-73.3279 -376.487 -119.38");
	addBob2("-73.3279 -382.85 -119.38");
	addBob2("-73.3279 -389.213 -119.38");
	addBob2("-73.3279 -395.576 -119.38");
	addBob2("-73.3279 -401.939 -119.38");
	addBob2("-73.3279 -408.302 -119.38");
	addBob2("-73.3279 -414.665 -119.38");

	return(%obj);
}

