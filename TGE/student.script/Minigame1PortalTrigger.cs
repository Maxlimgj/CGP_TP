datablock TriggerData(Minigame1PortalTrigger)
{
	tickPeriodMS = 100;
};

function Minigame1PortalTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowMinigame1Start');

	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function Minigame1PortalTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowMinigame1Start()
{
	MessageBoxYesNo("", "Welcome. Do you want to play a game? (Play to get clues on the maze)", "Minigame1Location(myPlayer);", "");
}

function Minigame1Location(%obj)
{
	%obj.setTransform("89.8219 -460.018 -137.93 0 0 1 2.30534");
	MessageBoxOK("", "You have 300s");
	startTimer(300);
	return(%obj);
}

