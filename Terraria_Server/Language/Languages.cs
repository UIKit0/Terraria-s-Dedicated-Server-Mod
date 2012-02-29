﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria_Server.Misc;
using System.Xml;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;
using Terraria_Server.Logging;

namespace Terraria_Server.Language
{
	public static class Languages
	{
#region Properties

		public static String Disconnected { get; set; }
		public static String PermissionsError { get; set; }
		public static String ExitRequestCommand { get; set; }
		public static String ExpiredCommandMessage { get; set; }
		public static String XRequestedShutdown { get; set; }
		public static String PropertiesReload { get; set; }
		public static String CurrentPlayers { get; set; }
		public static String NoPlayers { get; set; }
		public static String SavingWorld { get; set; }
		public static String SavingData { get; set; }
		public static String SavingComplete { get; set; }
		public static String InvalidPage { get; set; }
		public static String RemovedFrom { get; set; }
		public static String Add { get; set; }
		public static String Added { get; set; }
		public static String Remove { get; set; }
		public static String PleaseReview { get; set; }
		public static String WhilelistFailedSave { set; get; }
		public static String OPlistFailedSave { get; set; }
		public static String Command { get; set; }
		public static String IPExpected { get; set; }
		public static String TimeSet { get; set; }
		public static String CurrentTime { get; set; }
		public static String BossNotSpecified { get; set; }
		public static String BossSummonedBy { get; set; }
		public static String Clear { get; set; }
		public static String NoItemIDNameProvided { get; set; }
		public static String ExplosionsAreNow { get; set; }
		public static String ThisIsPlayerCommand { get; set; }
		public static String CannotQuestGiverWithoutTDCM { get; set; }
		public static String QuestGiverAlreadySpawned { get; set; }
		public static String YouMustWaitBeforeAnotherCommand { get; set; }
		public static String MoreThanOneItemFoundNameId { get; set; }
		public static String MoreThanOneItemFoundType { get; set; }
		public static String TooManyArguments { get; set; }
		public static String NobodyOnline { get; set; }
		public static String NPCDoesntExist { get; set; }
		public static String DontSpawnThatMany { get; set; }
		public static String ExpectedSpawnInteger { get; set; }
		public static String NeedTeleportTarget { get; set; }
		public static String TeleportedToSpawn { get; set; }
		public static String TeleportFailed { get; set; }
		public static String PlayerNotFound { get; set; }
		public static String InvalidCoords { get; set; }
		public static String CouldNotFindPlayer { get; set; }
		public static String OnlyPlayerCanUseCommand { get; set; }
		public static String SettlingLiquids { get; set; }
		public static String Complete { get; set; }
		public static String LiquidsAlreadySettled { get; set; }
		public static String YouAreNowOP { get; set; }
		public static String YouAreNowDeop { get; set; }
		public static String SuccessfullyLoggedInOP { get; set; }
		public static String FailedLoginWrongPassword { get; set; }
		public static String IncorrectOPPassword { get; set; }
		public static String YouNeedPrivileges { get; set; }
		public static String SuccessfullyLoggedOutOP { get; set; }
		public static String NPCSpawningIsNow { get; set; }
		public static String YouHaveBeenKickedBy { get; set; }
		public static String HasBeenKickedBy { get; set; }
		public static String KickSlotIsEmpty { get; set; }
		public static String KickPlayerNameNull { get; set; }
		public static String RestartingServer { get; set; }
		public static String StartingServer { get; set; }
		public static String PurgingProjectiles { get; set; }
		public static String PurgingNPC { get; set; }
		public static String PurgingItems { get; set; }
		public static String LoadedPlugins { get; set; }
		public static String NoPluginsLoaded { get; set; }
		public static String IssueFindingPlayer { get; set; }
		public static String NoOnlinePlayersToSpawnNear { get; set; }
		public static String NeedsToBeNightTime { get; set; }
		public static String HardModeAlreadyEnabled { get; set; }
		public static String StartingHardMode { get; set; }

		public static String RPGMode_Allowed { get; set; }
		public static String RPGMode_Refused { get; set; }

		public static String ItemRejection_Added { get; set; }
		public static String ItemRejection_ItemExists { get; set; }
		public static String ItemRejection_Removed { get; set; }
		public static String ItemRejection_ItemDoesntExist { get; set; }
		public static String ItemRejection_Cleared { get; set; }

		public static String Ban_You { get; set; }
		public static String Ban_Banned { get; set; }
		public static String Ban_FailedToSave { get; set; }
		public static String Ban_UnBanned { get; set; }

		//Commands
		public static String CommandDescription_Exit { get; set; }
		public static String CommandDescription_SaveAll { get; set; }
		public static String CommandDescription_ReloadPlugins { get; set; }
		public static String CommandDescription_OnlinePlayers { get; set; }
		public static String CommandDescription_Me { get; set; }
		public static String CommandDescription_Say { get; set; }
		public static String CommandDescription_Slots { get; set; }
		public static String CommandDescription_Kick { get; set; }
		public static String CommandDescription_Ban { get; set; }
		public static String CommandDescription_UnBan { get; set; }
		public static String CommandDescription_Whitelist { get; set; }
		public static String CommandDescription_Rcon { get; set; }
		public static String CommandDescription_Status { get; set; }
		public static String CommandDescription_Time { get; set; }
		public static String CommandDescription_Help { get; set; }
		public static String CommandDescription_Give { get; set; }
		public static String CommandDescription_SpawnNpc { get; set; }
		public static String CommandDescription_Teleport { get; set; }
		public static String CommandDescription_TeleportHere { get; set; }
		public static String CommandDescription_SettleLiquids { get; set; }
		public static String CommandDescription_Op { get; set; }
		public static String CommandDescription_DeOp { get; set; }
		public static String CommandDescription_OpLogin { get; set; }
		public static String CommandDescription_OpLogout { get; set; }
		public static String CommandDescription_NpcSpawns { get; set; }
		public static String CommandDescription_Restart { get; set; }
		public static String CommandDescription_Purge { get; set; }
		public static String CommandDescription_Plugins { get; set; }
		public static String CommandDescription_Plugin { get; set; }
		public static String CommandDescription_SpawnBoss { get; set; }
		public static String CommandDescription_ItemRej { get; set; }
		public static String CommandDescription_Explosions { get; set; }
		public static String CommandDescription_MaxPlayers { get; set; }
		public static String CommandDescription_Q { get; set; }
		public static String CommandDescription_Refresh { get; set; }
		public static String CommandDescription_HardMode { get; set; }
		public static String CommandDescription_LanguageReload { get; set; }
		public static String CommandDescription_Backups { get; set; }

		public static String Generation_Terrain { get; set; }
		public static String Generation_AddingNPCs { get; set; }
		public static String Generation_AddingSand { get; set; }
		public static String Generation_GeneratingHills { get; set; }
		public static String Generation_AddingSnow { get; set; }
		public static String Generation_PuttingDirtBehindDirt { get; set; }
		public static String Generation_PlacingRocks { get; set; }
		public static String Generation_PlaceDirtWithinRocks { get; set; }
		public static String Generation_AddingClay { get; set; }
		public static String Generation_MakingRandomHoles { get; set; }
		public static String Generation_GeneratingSmallCaves { get; set; }
		public static String Generation_GeneratingLargeCaves { get; set; }
		public static String Generation_GeneratingSurfaceCaves { get; set; }
		public static String Generation_GeneratingJungle { get; set; }
		public static String Generation_GeneratingFloatingIslands { get; set; }
		public static String Generation_AddingMushroomPatches { get; set; }
		public static String Generation_PlacingMudInDirt { get; set; }
		public static String Generation_AddingShinies { get; set; }
		public static String Generation_AddingWebs { get; set; }
		public static String Generation_CreatingTheUnderworld { get; set; }
		public static String Generation_AddingWaterBodies { get; set; }
		public static String Generation_MakingTheWorldEvil { get; set; }
		public static String Generation_GeneratingMoutainCaves { get; set; }
		public static String Generation_CreatingBeachesOnEitherSide { get; set; }
		public static String Generation_AddingGems { get; set; }
		public static String Generation_GravitatingSand { get; set; }
		public static String Generation_CleaningUpDirtBackgrounds { get; set; }
		public static String Generation_PlacingAltars { get; set; }
		public static String Generation_SettlingLiquids { get; set; }
		public static String Generation_PlacingLifeCrystals { get; set; }
		public static String Generation_HidingTreasure { get; set; }
		public static String Generation_HidingMoreTreasure { get; set; }
		public static String Generation_HidingJungleTreasure { get; set; }
		public static String Generation_HidingWaterTreasure { get; set; }
		public static String Generation_AddingIslandHouses { get; set; }
		public static String Generation_PlacingBreakables { get; set; }
		public static String Generation_PlacingHellForges { get; set; }
		public static String Generation_SpreadingGrass { get; set; }
		public static String Generation_GrowingCacti { get; set; }
		public static String Generation_PlantingSunflowers { get; set; }
		public static String Generation_PlantingTrees { get; set; }
		public static String Generation_PlantingHerbs { get; set; }
		public static String Generation_PlantingWeeds { get; set; }
		public static String Generation_GrowingVines { get; set; }
		public static String Generation_PlantingFlowers { get; set; }
		public static String Generation_PlantingMushrooms { get; set; }
		public static String Generation_CreatingDungeons { get; set; }
		public static String Generation_PlacingTraps { get; set; }

		public static String Startup_Initializing { get; set; }
		public static String Startup_SettingUpPaths { get; set; }
		public static String Startup_SettingUpProperties { get; set; }
		public static String Startup_NoPropertiesFileFound { get; set; }
		public static String Startup_PropertiesCreationComplete { get; set; }
		public static String Startup_IssueDeletingPID { get; set; }
		public static String Startup_PressAnyKeyToExit { get; set; }
		public static String Startup_IssueCreatingPID { get; set; }
		public static String Startup_PIDCreated { get; set; }
		public static String Startup_RestartingIntoNewUpdate { get; set; }
		public static String Startup_ErrorUpdating { get; set; }
		public static String Startup_StartingRCON { get; set; }
		public static String Startup_StartingPermissions { get; set; }
		public static String Startup_PreparingServerData { get; set; }
		public static String Startup_LoadingItemDefinitions { get; set; }
		public static String Startup_LoadingNPCDefinitions { get; set; }
		public static String Startup_LoadingProjectileDefinitions { get; set; }
		//public static String Startup_LoadingLanguageDefinitions { get; set; }
		public static String Startup_LanguageFileOOD { get; set; }
		public static String Startup_LanguageFileUpdate { get; set; }
		public static String Startup_LoadingPlugins { get; set; }
		public static String Startup_PluginsLoaded { get; set; }
		public static String Startup_GeneratingWorld { get; set; }
		public static String Startup_GeneratedSeed { get; set; }
		public static String Startup_WorldSizingError { get; set; }
		public static String Startup_GeneratingWithCustomSize { get; set; }
		public static String Startup_StartingTheServer { get; set; }
		public static String Startup_YouCanNowInsertCommands { get; set; }
		public static String Startup_IssueParsingConsoleCommand { get; set; }
		public static String Startup_Exiting { get; set; }
		public static String Startup_CrashlogGeneratedBy { get; set; }
		public static String Startup_ProgramCrash { get; set; }
		public static String Startup_PleaseSend { get; set; }
		public static String Startup_LogEnd { get; set; }

		public static String CreatingTileArrayOf { get; set; }
		public static String Players { get; set; }
		public static String InitializingSlotManagerFor { get; set; }
		public static String ServerStartedOn { get; set; }

		public static String Water_WaterHasBeenSettled { get; set; }
		public static String Water_PerformingWaterCheck { get; set; }
		public static String Water_PreparingLiquids { get; set; }

		public static String CheckingTileAlignment { get; set; }
		public static String LoadingWorldTiles { get; set; }
		public static String ResettingGameObjects { get; set; }
		public static String SavedFile { get; set; }
		public static String SavedTo { get; set; }
		public static String Failed { get; set; }
#endregion

		public static bool LoadClass(string filePath, bool restore = false, bool error = true)
		{
			if (!File.Exists(filePath) || restore)
			{
				if (File.Exists(filePath))
					File.Delete(filePath);

				using (var ctx = Assembly.GetExecutingAssembly().GetManifestResourceStream(Collections.Registries.DEFINITIONS + filePath))
				{
					using (var stream = File.OpenWrite(filePath))
					{
						var buff = new byte[ctx.Length];
						ctx.Read(buff, 0, buff.Length);
						stream.Write(buff, 0, buff.Length);
					}
				}
			}

			using (var stream = File.Open(filePath, FileMode.Open))
			{
				var document = new XmlDocument();
				document.Load(stream);

				var type = typeof(Languages);

				foreach (XmlNode node in document.ChildNodes[0].ChildNodes)
				{
					try
					{
						var property = node.Name;
						var value = node.InnerText;

						var properties = from x in type.GetProperties() where x.Name == property select x;

						foreach (var prop in properties)
							prop.SetValue(null, value, null);
					}
					catch (Exception e)
					{
						if (error)
						{
							ProgramLog.Error.Log("Error parsing language file\n{0}", e);
							return false;
						}
					}
				}
			}
			return true;
		}

		public static bool IsOutOfDate()
		{
			var type = typeof(Languages);
			var properties = from x in type.GetProperties() where x.GetValue(null, null) == null select x;
			
			return properties.Count() > 0;
		}
	}
}