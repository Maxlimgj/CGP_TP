function startTimer(%time) {
	echo("timer started");
	schedule(1000, 0, tickTimer, %time);
}
function tickTimer(%time) {	
	echo(%time);
	%time--;	
	$eventID = schedule(1000, 0, tickTimer, %time);
	if(%time == 0)
	{
		stopTimer();
		MessageBoxOK("","Time's Up. You failed.");
		myPlayer.setTransform("-44.1635 -19.7429 -40.1305 1 0 0 0");
	}
}

function stopTimer(){	
	cancel($eventID);
}

function checkBob()
{
	echo($count);
}