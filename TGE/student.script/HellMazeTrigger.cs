datablock TriggerData(HellMazeTrigger)
{
	tickPeriodMS = 100;
};

function HellMazeTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowStart');
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function HellMazeTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowStart()
{
	MessageBoxOK("", "Welcome to the Hell Maze.");
}