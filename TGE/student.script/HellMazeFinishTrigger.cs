datablock TriggerData(HellMazeFinishTrigger)
{
	tickPeriodMS = 100;
};

function HellMazeFinishTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowEnd');
	%obj.setTransform("-40.4877 -21.5638 13.1801 0 0 1 187.206");
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function HellMazeFinishTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowEnd()
{
	MessageBoxOK("", "Congratulations. On to the Golden Tower");
}