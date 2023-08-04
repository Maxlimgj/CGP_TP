datablock ItemData(Balls)
{
	shapeFile = "tutorial.base/data/shapes/markers/ball.dts";
	mass = 1;
};

function createBall()
{
	%newBall1 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall1);
	
	%newBall2 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall2);
		
	%newBall3 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall3);
	
	%newBall4 = new Item(){
	datablock = Balls;
	};
	
	missionCleanup.add(%newBall4);
	
	%newBall5 = new Item(){
	datablock = Balls;
	};
	
	missionCleanup.add(%newBall5);
	%newBall6 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall6);
	
	%newBall7 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall7);
	
	%newBall8 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall8);
	
	%newBall9 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall9);
	
	%newBall10 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall10);
	
	
	%newBall11 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall11);
	
	
	%newBall12 = new Item(){
	datablock = Balls;
	};
	missionCleanup.add(%newBall12);	
	
	%newBall1.setTransform("-84.9762 -428.035 -118.217 1 0 0 0");
	%newBall2.setTransform("-94.2367 -422.576 -118.631 1 0 0 0");
	%newBall3.setTransform("-89.3076 -416.006 -112.017 1 0 0 0");
	%newBall4.setTransform("-83.2418 -408.9 -118.642 1 0 0 0");
	%newBall5.setTransform("-93.7515 -402.013 -116.935 1 0 0 0");
	%newBall6.setTransform("-96.3392 -393.314 -118.395 1 0 0 0");
	%newBall7.setTransform("-83.4157 -387.833 -119.015 1 0 0 0");
	%newBall8.setTransform("-96.5907 -380.844 -118.768 1 0 0 0");
	%newBall9.setTransform("-88.0798 -375.785 -112.953 1 0 0 0");
	%newBall10.setTransform("-85.3907 -366.759 -118.642 1 0 0 0");
	%newBall11.setTransform("-95.2367 -355.907 -118.417 1 0 0 0");
	%newBall12.setTransform("-84.9762 -428.035 -118.217 1 0 0 0");
		
}


function animBallsLeft(%shape, %dist)
{
	%xfrm = %shape.getTransform();
	%lx = getword(%xfrm, 0);
	%ly = getword(%xfrm, 1);
	%lz = getword(%xfrm, 2);
	%rx = getword(%xfrm, 3);
	%ry = getword(%xfrm, 4);
	%rz = getword(%xfrm, 5);
	%rd = getword(%xfrm, 6);
	%lx -= %dist;
	
	if(%dist > 1)
		%turn=true;
	
	if(%turn)
	{
		%lx += %dist;
	}
	else
	{
		%lx -= %dist;
	}

	%shape.setTransform(%lx SPC %ly SPC %lz SPC %rx SPC %ry SPC %rz SPC %rd);
	$timerid = schedule(200, %shape, animBallsLeft, %shape, %dist, 0, 0);
}

function anim()
{	
	createBall();
	animBallsLeft(%newBall1, 0.1);
}