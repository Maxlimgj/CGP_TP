datablock TriggerData(TempleOfEvilTrigger)
{
 // tickPeriodMS is a value is used to control how often the console
 // onTriggerTick callback is called while there are any objects
 // in the trigger. The default value is 100 MS.
 tickPeriodMS = 100;
};
function TempleOfEvilTrigger::onEnterTrigger( %this, %trigger, %obj )
{
 echo( "The player has just entered the Temple of Evil! - Not the smartest move!");    
 addOni(); // This method is called whenever an object enters the %trigger
 addbob();
addSnorlax();
 // area, the object is passed as %obj.  The default onEnterTrigger
 // method (in the C++ code) invokes the ::onTrigger(%trigger,1) method on
 // every object (whatever it's type) in the same group as the trigger.
   callSandstorm();
 Parent::onEnterTrigger( %this, %trigger, %obj );

}
function TempleOfEvilTrigger::onLeaveTrigger( %this, %trigger, %obj )
{
 echo( "The player has just left the Temple of Evil! - The player lives to fight another day!");
 // This method is called whenever an object leaves the %trigger
 // area, the object is passed as %obj.  The default onLeaveTrigger
 // method (in the C++ code) invokes the ::onTrigger(%trigger,0) method on
 // every object (whatever it's type) in the same group as the trigger.
cancelSandstorm();
 Parent::onLeaveTrigger( %this, %trigger, %obj );

}
function TempleOfEvilTrigger::onTickTrigger( %this, %trigger )
{
 echo( "The player is still in the Temple of Evil! - Calling all monsters!");
 // This method is called every tickPerioMS, as long as any
 // objects intersect the trigger. The default onTriggerTick
 // method (in the C++ code) invokes the ::onTriggerTick(%trigger) method on
 // every object (whatever it's type) in the same group as the trigger.
 // You can iterate through the objects in the list by using these
 // methods:
 //    %this.getNumObjects();
 //    %this.getObject(n);
 Parent::onTickTrigger( %this, %trigger );
}

function callSandstorm()
{
 datablock PrecipitationData(Sandstorm)
 {
  soundProfile = "Sandstormsound";
  dropTexture = "~/data/environment/sandstorm";
  splashTexture = "~/data/environment/sandstorm2";
  dropSize = 10;
  splashSize = 2;
  useTrueBillboards = false;
  splashMS = 250;
 };
 
 $obj = new Precipitation(Sandstorm){
  canSaveDynamicFields = "1";
  position = "60.9891 -10.9271 0.55";
  rotation = "1 0 0 0";
  scale = "7 7 7";
  nameTag = "Sandstorm";
  dataBlock = "Sandstorm";
  minSpeed = "1";
  maxSpeed = "1";
  minMass = "1";
  maxMass = "1";
  maxTurbulence = "10";
  turbulenceSpeed = "0.1";
  //rotateWithCamVel = 0";
  useTurbulence = "1";
  numDrops = "500";
  boxWidth = "150";
  boxHeight = "100";
  doCollision = "0";
 };
}
function cancelSandstorm()
{
 $obj.delete();
}