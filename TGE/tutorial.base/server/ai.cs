
	
datablock PlayerData(oni)
{
   className = Armor;
   shapeFile = "~/data/shapes/oni/oni.dts";
   shootingDelay = 100;
   BoundingBox = "2 2 5";
   maxDamage = 2000;
   maxForwardSpeed = 20;
   maxSideSpeed = 18;
};

function oni::onAdd(%this,%obj)
{
   // Called when the PlayerData datablock is first 'read' by the engine (executable)

    parent::onAdd( %this, %obj );
    %obj.mountImage( RocketLauncherForSnorlaxImage, 0 );   //<<Mount Weapon 
    %obj.setImageAmmo( 0, 1 );
}


function addoni(%location)
{
	
          $pos = %location; // Add this line for the final position of the AI enemy 35 -410  0.02


    %bott = new AIPlayer()
    {datablock = oni;
    position = $pos;

	scale = "3 3 3";
    bottID = 0;
};
	echo($pos);
	echo($maxDmg);
    %bott.bottID = %bott;
    updateOni(%bott.bottID);
    $bossSpawnNoTime++;

}

function oni::onCollision(%this, %obj, %col)
{	
	myPlayer.applyDamage(5);
	echo("Damage Taken: 5");
}

function updateOni(%idd)
{

       
	%bottX = getword(%idd.getTransform(),0);
	%bottY = getword(%idd.getTransform(),1);
	%bottZ = getword(%idd.getTransform(),2);

	%playerXX = getword($player.getTransform(),0);
	%playerYY = getword($player.getTransform(),1);
	%playerZZ = getword($player.getTransform(),2);
	%dist = mSqrt((%playerXX - %bottX)*(%playerXX - %bottX) + (%playerYY- %bottY)*(%playerYY - %bottY));
	
        	if (%dist < 50)
		{
            %xx = %playerXX-3;
            %yy = %playerYY-3;
			%idd.setMoveDestination(%xx SPC %yy);
			%idd.setAimObject($player);
			%idd.setImageTrigger(0,1);
        }
		
    if(%idd.getState() !$= "Dead")
    {
	    schedule(2000, 0, updateOni, %idd);
    }
	else
	{
		%idd.playDeathAnimation();
                MessageBoxOK("", "Congratulations. You won.");
                //when boss die, can add music here
		%idd.setImageTrigger(0,0);
		%idd.delete();
		
		
		//MessageBoxYesNo( "You have successfully defended your castle!", "View your score?", "showScoreScreen();","chooseNewMission();");
		
		
	}
}

function oni::playDeathAnimation(%this)
{
	%this.setActionThread("die");
}



