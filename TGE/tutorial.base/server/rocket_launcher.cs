//rocket_launcher.cs 
//-----------------------------------------------------------------------------
//
// This object hierarchy exists for each rocket fired:
//
// RocketProjectile -> RocketExhaustParticleEmitter -> RocketExhaustParticle
//                  -> RocketExplosion (created upon impact, see below)
//
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//
// If a rocket hits something, this object hierarchy will become active as
// each rocket will create an explosion effect upon impact:
//
// RocketExplosion -> RocketExplosionFireParticleEmitter   -> RocketExplosionFireParticle
//       -> RocketExplosionSmokeParticleEmitter  -> RocketExplosionSmokeParticle
//       -> RocketExplosionSparksParticleEmitter -> RocketExplosionSparksParticles
//
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// When a rocket hits something, this is what it will sound like...
//-----------------------------------------------------------------------------
datablock AudioProfile( RocketExplosionSound )
{
 filename = "~/data/shapes/rocket_launcher/rocket_explosion.ogg";
 description = AudioDefault3d;
 preload = true;
};
//-----------------------------------------------------------------------------
// When a rocket explodes upon impact, it will emit smoke like this...
//-----------------------------------------------------------------------------
datablock ParticleData( RocketExplosionSmokeParticle )
{
 textureName = "~/data/shapes/rocket_launcher/smoke";
 useInvAlpha =  true;
 dragCoeffiecient = 100.0;
 inheritedVelFactor = 0.3;
 constantAcceleration = -0.3;
 lifetimeMS = 1200;
 lifetimeVarianceMS = 300;
 times[0] = 0.0;
 times[1] = 0.5;
 times[2] = 1.0;
 colors[0] = "0.56 0.36 0.26 1.0";
 colors[1] = "0.2 0.2 0.2 1.0";
 colors[2] = "0.0 0.0 0.0 0.0";
 sizes[0] = 4.0;
 sizes[1] = 2.5;
 sizes[2] = 1.0;
};
datablock ParticleEmitterData( RocketExplosionSmokeParticleEmitter )
{
 particles = "RocketExplosionSmokeParticle";
 lifetimeMS = 250;
 lifetimeVarianceMS = 0;
 ejectionPeriodMS = 10;
 periodVarianceMS = 0;
 ejectionVelocity = 4;
 velocityVariance = 0.5;
};
//-----------------------------------------------------------------------------
// When a rocket explodes upon impact, it will emit fire like this...
//-----------------------------------------------------------------------------
datablock ParticleData( RocketExplosionFireParticle )
{
 textureName = "~/data/shapes/rocket_launcher/fire";
 useInvAlpha =  false;
 dragCoeffiecient = 100.0;
 inheritedVelFactor = 0.3;
 lifetimeMS = 1200;
 lifetimeVarianceMS = 300;
 times[0] = 0.0;
 times[1] = 0.5;
 times[2] = 1.0;
 colors[0] = "0.8 0.4 0.0 0.8";
 colors[1] = "0.2 0.0 0.0 0.8";
 colors[2] = "0.0 0.0 0.0 0.0";
 sizes[0] = 1.5;
 sizes[1] = 0.9;
 sizes[2] = 0.5;
};
datablock ParticleEmitterData( RocketExplosionFireParticleEmitter )
{
 particles = "RocketExplosionFireParticle";
 lifetimeMS = 250;
 lifetimeVarianceMS = 0;
 ejectionPeriodMS = 10;
 periodVarianceMS = 0;
 ejectionVelocity = 0.8;
 velocityVariance = 0.5;
};
//-----------------------------------------------------------------------------
// When a rocket explodes upon impact, it will emit sparks like this...
//-----------------------------------------------------------------------------
datablock ParticleData( RocketExplosionSparksParticles )
{
 textureName = "~/data/shapes/rocket_launcher/spark";
 dragCoefficient      = 1;
 gravityCoefficient   = 0.0;
 inheritedVelFactor   = 0.2;
 constantAcceleration = 0.0;
 lifetimeMS = 500;
 lifetimeVarianceMS = 350;
 times[0] = 0.0;
 times[1] = 0.5;
 times[2] = 1.0;
 colors[0] = "1.0 0.0 0.0 1.0";
 colors[1] = "1.0 1.0 0.0 0.8";
 colors[2] = "1.0 1.0 1.0 0.1";
 sizes[0] = 0.20;
 sizes[1] = 0.15;
 sizes[2] = 0.5;
};
datablock ParticleEmitterData( RocketExplosionSparksParticleEmitter )
{
 particles = "RocketExplosionSparksParticles";
 lifetimeMS = 150;
    lifetimeVarianceMS = 0;
 ejectionPeriodMS = 2;
 periodVarianceMS = 0;
 ejectionVelocity = 30;
 velocityVariance = 10;
};
//-----------------------------------------------------------------------------
// When a rocket hits something, it will explode like this...
//-----------------------------------------------------------------------------
datablock ExplosionData( RocketExplosion )
{
 soundProfile = RocketExplosionSound;
 lifeTimeMS = 1200;
    lifetimeVarianceMS = 0;
 // Volume particles
 particleEmitter = RocketExplosionFireParticleEmitter;
 particleDensity = 100;
 particleRadius  = 2;
 // Point emission particles
 emitter[0] = RocketExplosionSmokeParticleEmitter;
 emitter[1] = RocketExplosionSparksParticleEmitter;
 // This will make the camera shake when a player gets hit by a rocket.
    // Shoot your own feet to see this effect in action.
 shakeCamera      = true;
 camShakeFreq     = "10.0 11.0 10.0";
 camShakeAmp      = "1.0 1.0 1.0";
 camShakeDuration = 0.5;
 camShakeRadius   = 10.0;
 // This will create a dynamic lighting effect in the vicinity of the 
    // rocket's explosion.
 lightStartRadius = 6;
 lightEndRadius   = 3;
 lightStartColor  = "0.5 0.5 0.0";
 lightEndColor    = "0.0 0.0 0.0";
};
//-----------------------------------------------------------------------------
// When a rocket is flying through the air, it will emit exhaust like this...
//-----------------------------------------------------------------------------
datablock ParticleData( RocketExhaustParticle )
{
 textureName = "~/data/shapes/rocket_launcher/smoke";
 useInvAlpha = false;
 lifetimeMS = 2000;
 lifetimeVarianceMS = 250;
 times[0] = 0.0;
 times[1] = 0.5;
 times[2] = 1.0;
 colors[0] = "0.8 0.3 0.0 1.0";
 colors[1] = "0.1 0.1 0.1 0.7";
 colors[2] = "0.1 0.1 0.1 0.0";
 sizes[0] = 0.1;
 sizes[1] = 0.5;
 sizes[2] = 1.0;
};
datablock ParticleEmitterData( RocketExhaustParticleEmitter )
{
 particles = RocketExhaustParticle;
 ejectionPeriodMS = 5;
 periodVarianceMS = 2;
 ejectionVelocity = 0.1;
 velocityVariance = 0.1;
};
//-----------------------------------------------------------------------------
// When the rocket launcher fires, it will emit a single rocket which behaves 
// like this...
//-----------------------------------------------------------------------------
datablock ProjectileData( RocketProjectile )
{
 projectileShapeName = "~/data/shapes/rocket_launcher/rocket.dts";
 muzzleVelocity = 120;
 armingDelay    = 0;
 lifetime       = 5000;
 fadeDelay      = 5000;
 isBallistic    = true;
 gravityMod     = 0.5;
    // The projectile will cast light on the ground as it travels.
 hasLight    = true;
 lightRadius = 5;
 lightColor  = "0.5 0.5 0.25";
    // The rocket will emit exhaust particles using this
 particleEmitter = RocketExhaustParticleEmitter;
    // We'll create one of these if our rocket hits something
 explosion    = RocketExplosion; 
 directDamage = 20;
 radiusDamage = 10;
 damageRadius = 1.5;
};
function RocketProjectile::onCollision( %this, %obj, %col, %fade, %pos, %normal )
{
    echo("RocketProjectile::onCollision called! ----------------------------");
    // TO DO: Add code here to calculate rocket damage for any object hit.
}
//-----------------------------------------------------------------------------
// When the player uses the rocket launcher, it will behave like this...
//-----------------------------------------------------------------------------
datablock ShapeBaseImageData( RocketLauncherImage )
{
 shapeFile = "~/data/shapes/rocket_launcher/rocket_launcher.dts";
    projectile = RocketProjectile;
    projectileType = Projectile;
    fireTimeout = 0;
 emap = true;
    // When firing from a point offset from the eye, muzzle correction will 
    // adjust the muzzle vector to point to the eye LOS point. Since this 
    // weapon doesn't actually fire from the muzzle point, we need to turn 
    // this off.
    correctMuzzleVector = false;
 // Specify mountPoint & offset for 3rd person, and eyeOffset for first 
    // person rendering.
 mountPoint = 0;
    offset = "0.0 0.0 0.0";
    eyeOffset = "0.0 0.0 0.0";
 // Images have a state system which controls how the animations are run, 
 // which sounds are played, script callbacks, etc. This state system is 
 // downloaded to the client so that clients can predict state changes and 
 // animate accordingly.  The following system supports basic 
 // ready->fire->reload transitions as well as a no-ammo->dryfire idle 
 // state.
 // Initial start up state
 stateName[0]                     = "Preactivate";
 stateTransitionOnLoaded[0]       = "Activate";
 stateTransitionOnNoAmmo[0]       = "NoAmmo";
 // Activating the gun. Called when the weapon is first mounted and there 
 // is ammo.
 stateName[1]                     = "Activate";
 stateTransitionOnTimeout[1]      = "Ready";
 stateTimeoutValue[1]             = 0.5;
 stateSequence[1]                 = "Activate";
 // Ready to fire, just waiting for the trigger
 stateName[2]                     = "Ready";
 stateTransitionOnNoAmmo[2]       = "NoAmmo";
 stateTransitionOnTriggerDown[2]  = "Fire";
 // Fire the weapon. Calls the onFire function when our player shoots.
 stateName[3]                     = "Fire";
 stateTransitionOnTimeout[3]      = "Reload";
 stateTimeoutValue[3]             = 0.1;
 stateFire[3]                     = true;
 stateRecoil[3]                   = LightRecoil;
 stateAllowImageChange[3]         = false;
 stateSequence[3]                 = "Fire";
 stateScript[3]                   = "onFire";
 stateEmitterTime[3]              = 0.3;
 // Play the relead animation, and transition into
 stateName[4]                     = "Reload";
 stateTransitionOnNoAmmo[4]       = "NoAmmo";
 stateTransitionOnTimeout[4]      = "Ready";
 stateTimeoutValue[4]             = 0.1;
 stateAllowImageChange[4]         = false;
 stateSequence[4]                 = "Reload";
 stateEjectShell[4]               = true;
 // No ammo in the weapon, just idle until something shows up. Play the dry 
 // fire sound if the trigger is pulled.
 stateName[5]                     = "NoAmmo";
 stateTransitionOnAmmo[5]         = "Reload";
 stateSequence[5]                 = "NoAmmo";
 stateTransitionOnTriggerDown[5]  = "DryFire";
 // No ammo! Just perform a dry fire until the player finds more ammo.
 stateName[6]                     = "DryFire";
 stateTimeoutValue[6]             = 1.0;
 stateTransitionOnTimeout[6]      = "NoAmmo";
};
function RocketLauncherImage::onFire( %this, %obj, %slot )
{
 %projectile = %this.projectile;
 // Determine initial projectile velocity based on the gun's muzzle point 
 // and the object's current velocity...
 %muzzleVector   = %obj.getMuzzleVector( %slot );
 %objectVelocity = %obj.getVelocity();
 %muzzleVelocity = VectorAdd( VectorScale(%muzzleVector, %projectile.muzzleVelocity),
                              VectorScale(%objectVelocity, %projectile.velInheritFactor) );
 // Create a new rocket projectile object...
 %p = new (%this.projectileType)()
 {
  dataBlock       = %projectile;
  initialVelocity = %muzzleVelocity;
  initialPosition = %obj.getMuzzlePoint(%slot);
  sourceObject    = %obj;
  sourceSlot      = %slot;
  client          = %obj.client;
 };
 MissionCleanup.add( %p );
 return %p;
}
