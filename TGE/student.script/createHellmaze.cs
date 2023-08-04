datablock ItemData(hellmaze)
{
	shapeFile = "D:/student/tutorial.base/data/shapes/3dtorquelogo/hellmaze.dif";
	mass = 1;
	friction = 1;
};

function createHellmaze()
{
	%newLogo = new Item() { datablock = hellmaze; };
	missionCleanup.add(%newLogo);
	
	%newLogo.setTransform("29.8964 -398.718 20.2385");
	echo("Inserting Shape" @ %newLogo);
	
	return %newLogo;
}




