datablock TriggerData(WaterDamage1)
{
	tickPeriodMS = 1000;
};

function WaterDamage1::onEnterTrigger(%this, %trigger, %obj)
{	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function WaterDamage1::onTickTrigger(%this, %trigger)
{
	echo("Damage Done: 50");
	myPlayer.applyDamage(50);
	Parent::onTickTrigger(%this, %trigger);
}

function WaterDamage1::onLeaveTrigger(%this, %trigger, %obj)
{
	
}

