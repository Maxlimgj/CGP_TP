datablock TriggerData(Minigame2FinishPortalTrigger)
{
	tickPeriodMS = 100;
};

function Minigame2FinishPortalTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowMinigame2End');
	%obj.setTransform("-50.4903 -5.07218 -40.1371 0 0 1 55.083");
	createArrows1();
	stopTimer();
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function Minigame2FinishPortalTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowMinigame2End()
{
	MessageBoxOK("", "Congratulations.");
}

function createArrows1()
{
	exec("student.script/createLeftArrow.cs");

	%newleftArrow2 = new Item(){
	datablock = LeftArrow;
	};
	missionCleanup.add(%newleftArrow2);

	%newleftArrow3 = new Item(){
	datablock = LeftArrow;
	};
	missionCleanup.add(%newleftArrow3);

	%newleftArrow4 = new Item(){
	datablock = LeftArrow;
	};
	missionCleanup.add(%newleftArrow4);

	%newleftArrow2.setTransform("-44.4549 11.0066 -38.8988 1 0 0 0");
	%newleftArrow3.setTransform("-55.5471 3.33993 -38.694 1 0 0 0");
	%newleftArrow4.setTransform("-65.824 -4.27461 -38.7114 1 0 0 0");
}
