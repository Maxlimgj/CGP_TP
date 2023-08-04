datablock TriggerData(GoldenTowerBeginTrigger)
{
	tickPeriodMS = 100;
};

function GoldenTowerBeginTrigger::onEnterTrigger(%this, %trigger, %obj)
{
	%client = %obj.client;
	commandToClient(%client, 'ShowGoldenTowerBegin');
	Parent::onEnterTrigger(%this, %trigger, %obj);
	%obj.mountImage( RocketLauncherImage, 0 );   //<<Mount Weapon 
    	%obj.setImageAmmo( 0, 1 );
}

function GoldenTowerBeginTrigger::onTickTrigger(%this, %trigger)
{	
	Parent::onTickTrigger(%this, %trigger);
}

function clientCmdShowGoldenTowerBegin()
{
	MessageBoxOK("", "Welcome to the Golden Tower. Proceed to the middle");
}

