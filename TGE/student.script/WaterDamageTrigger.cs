datablock TriggerData(WaterDamage)
{
	tickPeriodMS = 1000;
};

function WaterDamage::onEnterTrigger(%this, %trigger, %obj)
{	
	Parent::onEnterTrigger(%this, %trigger, %obj);
}

function WaterDamage::onTickTrigger(%this, %trigger)
{
	echo("Damage Done: 50");
	myPlayer.applyDamage(50);
	Parent::onTickTrigger(%this, %trigger);
}

function WaterDamage::onLeaveTrigger(%this, %trigger, %obj)
{
	
}

