datablock TriggerData(Minigame1FinishPortalTrigger)
{
	tickPeriodMS = 100;
};

function Minigame1FinishPortalTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowMinigame1End');
	%obj.setTransform("-11.2292 -15.389 -40.1517 0 0 -1 88.4421");
	createArrows();
	stopTimer();
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function Minigame1FinishPortalTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowMinigame1End()
{
	MessageBoxOK("", "Congratulations.");
}

function createArrows()
{
	exec("student.script/createLeftArrow.cs");
	exec("student.script/createDownArrow.cs");

	%newleftArrow = new Item(){
	datablock = LeftArrow;
	};
	missionCleanup.add(%newleftArrow);

	%newdownArrow = new Item(){
	datablock = DownArrow;
	};
	missionCleanup.add(%newdownArrow);

	%newleftArrow.setTransform("-16.1201 -10.3135 -40.2808 1 0 0 0");
	%newdownArrow.setTransform("-54.7677 -12.36 -38.6902 1 0 0 0");
}
