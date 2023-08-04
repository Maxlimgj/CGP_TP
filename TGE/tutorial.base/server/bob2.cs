
datablock PlayerData(bob2)
{
   className = Armor;
   shapeFile = "~/data/shapes/bob/bob.dts";
   shootingDelay = 1000;
   BoundingBox = "1 1 2";
   maxDamage = 300;
};

function bob2::onAdd(%this,%obj)
{
   // Called when the PlayerData datablock is first 'read' by the engine (executable)

    parent::onAdd( %this, %obj );
    %obj.mountImage( RocketLauncherForSnorlaxImage, 0 );   //<<Mount Weapon 
    %obj.setImageAmmo( 0, 1 );
}


function addBob2(%transformbob)
{
	
          $pos = %transformbob; // Add this line for the final position of the AI enemy 35 -410  0.02


    %bott = new AIPlayer()
    {datablock = bob2;
    position = $pos;

	scale = "2 2 2";
    bottID = 0;
};
	echo($pos);
	echo($maxDmg);
    %bott.bottID = %bott;
    updateBob2(%bott.bottID);
    $bossSpawnNoTime++;

}

function killBob2(%bott)
{
	%bott.applyDamage(1000);
}

function updateBob2(%idd)
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
	    schedule(2000, 0, updateBob2, %idd);
    }
	else
	{
                                //when boss die, can add music here
		%idd.setImageTrigger(0,0);
		%idd.delete();
		
		
		//MessageBoxYesNo( "You have successfully defended your castle!", "View your score?", "showScoreScreen();","chooseNewMission();");
		
		
	}
}




