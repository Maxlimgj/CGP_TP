$count = 0;

datablock PlayerData(bob)
{
   className = Armor;
   shapeFile = "~/data/shapes/bob/bob.dts";
   shootingDelay = 2;
   BoundingBox = "1 1 3";
   maxDamage = 300;
};

function addBob(%transformbob)
{
	
          $pos = %transformbob; // Add this line for the final position of the AI enemy 35 -410  0.02


    %bott = new AiPlayer()
    {datablock = bob;
    position = $pos;

	scale = "2 2 2";
    bottID = 0;
};
	echo($pos);
	echo($maxDmg);
    $count++;
	echo($count SPC "bob on the floor");
    %bott.bottID = %bott;
    updateBob(%bott.bottID);
    $bossSpawnNoTime++;

}


function bob::onCollision(%this, %obj, %col)
{	
	myPlayer.applyDamage(5);
	echo("Damage Taken: 5");
}

function updateBob(%idd)
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
            %xx = %playerXX-2;
            %yy = %playerYY-2;
			%idd.setMoveDestination(%xx SPC %yy);
			%idd.setAimObject($player);
			%idd.setImageTrigger(0,1);
	}
			else 
	{
		%idd.setAimObject(0);
		%idd.setImageTrigger(0,0);
	}
    if(%idd.getState() !$= "Dead")
    {
	    schedule(2000, 0, updateBob, %idd);
    }
	else
	{
                   				
		echo("bob died");             //when boss die, can add music here
		%idd.setImageTrigger(0,0);
		%idd.delete();

		
		//MessageBoxYesNo( "You have successfully defended your castle!", "View your score?", "showScoreScreen();","chooseNewMission();");
		
		
	}
}


