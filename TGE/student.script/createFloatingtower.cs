datablock ItemData(floatingtower)
{
	shapeFile = "D:/student/tutorial.base/data/shapes/3dtorquelogo/floatingtower.dif";
	mass = 1;
	friction = 1;
};

function createFloatingtower()
{
	%newLogo = new Item() { datablock = floatingtower; };
	missionCleanup.add(%newLogo);
	
	%newLogo.setTransform("29.8964 -398.718 20.2385");
	echo("Inserting Shape" @ %newLogo);
	
	return %newLogo;
}




