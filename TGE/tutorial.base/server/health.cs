//-----------------------------------------------------------------------------
// Torque Game Engine 
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

// Inventory items.  These objects rely on the item & inventory support
// system defined in item.cs and inventory.cs

//-----------------------------------------------------------------------------
// Health kits can be added to your inventory and used to heal up.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Audio profiles
//-----------------------------------------------------------------------------
//------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Health Kits are designed to be picked up and stored in the player's
// inventory until they "use" it. This differs from the Health Patches below
// that apply immediately on collision with a wounded player.
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------
// Health Patchs cannot be picked up and are not meant to be added to 
// inventory.  Health is applied automatically when an objects collides
// with a patch.
//-----------------------------------------------------------------------------

datablock ItemData(HealthPatch)
{
   // Mission editor category, this datablock will show up in the
   // specified category under the "shapes" root category.
   //category = "Health";

   // Basic Item properties
   shapeFile = "~/data/shapes/items/healthPatch.dts";
   mass = 1;
   friction = 1;
   elasticity = 0.3;
   

   // Dynamic properties defined by the scripts

  
};

function HealthPatch::onCollision(%this,%obj,%col)
{
   // Apply health to colliding object if it needs it.
   // Works for all shapebase objects.
   if (%col.getDamageLevel() != 0 && %col.getState() !$= "Dead" ) {
      %col.applyRepair(50);      
      //if (%col.client)
        // messageClient(%col.client, 'MsgHealthPatchUsed', '\c2Health Patch Applied');         
   }
}

function addHealthPatch(%location)
{
	%newHealthPatch = new Item(){
		datablock = HealthPatch;
		scale = "5 5 5";
	};
	missionCleanup.add(%newHealthPatch);
	%newHealthPatch.setTransform(%location);
	return %newHealthPatch;
}
