using LSMODElementsOfLife.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace LSMODElementsOfLife.Mounts.IcePack
{
	public class IcetaurFriendly : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.buff = mod.BuffType("IcetaurFriendlyBuff");
			mountData.heightBoost = 20;          //how high is the mount from the ground
			mountData.fallDamage = 0.5f;
			mountData.runSpeed = 8f;
			mountData.dashSpeed = 8f;
			//mountData.flightTimeMax = 300;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 10;
			mountData.acceleration = 0.19f;
			mountData.jumpSpeed = 6f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 8;            //mount frame/animation
			mountData.constantJump = true;
			int[] offset = new int[mountData.totalFrames];
			for (int i = 0; i < offset.Length; i++)
			{
				offset[i] = 20;
			}

			offset[1] += 2;
			offset[3] -= 2;

			mountData.playerYOffsets = offset;
			mountData.xOffset = 5;
			mountData.yOffset = 15;          //how high is the mount from the player
			mountData.bodyFrame = 0;          //player frame when it's on the mount
			mountData.playerHeadOffset = 18;

			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;

			mountData.runningFrameCount = 6;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 2;

			mountData.flyingFrameCount = 0;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;

			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 0;

			mountData.idleFrameCount = 4;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;

			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode == NetmodeID.Server)
			{
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width + 20;
			mountData.textureHeight = mountData.backTexture.Height;
		}
	}
}