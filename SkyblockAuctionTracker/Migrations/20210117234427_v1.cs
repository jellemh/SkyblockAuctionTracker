﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SkyblockAuctionTracker.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BazaarProductEntries",
                columns: table => new
                {
                    Timestamp = table.Column<long>(type: "bigint", nullable: false),
                    MappingID = table.Column<int>(type: "int", nullable: false),
                    SellPrice = table.Column<double>(type: "double", nullable: false),
                    BuyPrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazaarProductEntries", x => new { x.Timestamp, x.MappingID });
                });

            migrationBuilder.CreateTable(
                name: "BazaarProductIDMappings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazaarProductIDMappings", x => new { x.ID, x.Name });
                });

            migrationBuilder.InsertData(
                table: "BazaarProductIDMappings",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 0, "INK_SACK:3" },
                    { 158, "ENCHANTED_FLINT" },
                    { 159, "IRON_INGOT" },
                    { 160, "ENCHANTED_EMERALD_BLOCK" },
                    { 161, "ENCHANTED_CLAY_BALL" },
                    { 162, "GLOWSTONE_DUST" },
                    { 163, "GOLD_INGOT" },
                    { 164, "REVENANT_VISCERA" },
                    { 165, "TARANTULA_SILK" },
                    { 166, "TITANIC_EXP_BOTTLE" },
                    { 167, "ENCHANTED_MUTTON" },
                    { 168, "ENCHANTED_IRON" },
                    { 169, "SUPER_COMPACTOR_3000" },
                    { 170, "SUPER_EGG" },
                    { 171, "STOCK_OF_STONKS" },
                    { 172, "MITHRIL_ORE" },
                    { 173, "ENCHANTED_HAY_BLOCK" },
                    { 174, "ENCHANTED_PAPER" },
                    { 175, "ENCHANTED_BONE" },
                    { 176, "ENCHANTED_DIAMOND_BLOCK" },
                    { 177, "SPOOKY_BAIT" },
                    { 178, "SUPERIOR_FRAGMENT" },
                    { 179, "EMERALD" },
                    { 180, "ENCHANTED_RABBIT_FOOT" },
                    { 181, "LIGHT_BAIT" },
                    { 182, "ENCHANTED_ICE" },
                    { 183, "HOT_POTATO_BOOK" },
                    { 184, "CLAY_BALL" },
                    { 157, "ENCHANTED_JUNGLE_LOG" },
                    { 185, "OLD_FRAGMENT" },
                    { 156, "ENCHANTED_GOLD_BLOCK" },
                    { 154, "SPIKED_BAIT" },
                    { 127, "YOUNG_FRAGMENT" },
                    { 128, "ENCHANTED_CLOWNFISH" },
                    { 129, "REFINED_MINERAL" },
                    { 130, "ENCHANTED_GOLD" },
                    { 131, "ENCHANTED_RAW_CHICKEN" },
                    { 132, "ENCHANTED_WATER_LILY" },
                    { 133, "LOG:1" },
                    { 134, "TITANIUM_ORE" },
                    { 135, "BLUE_SHARK_TOOTH" },
                    { 136, "CATALYST" },
                    { 137, "LOG:3" },
                    { 138, "LOG:2" },
                    { 139, "BLESSED_BAIT" },
                    { 140, "ENCHANTED_GLOWSTONE_DUST" },
                    { 141, "ENCHANTED_INK_SACK" },
                    { 142, "ENCHANTED_CACTUS" },
                    { 143, "ENCHANTED_SUGAR_CANE" },
                    { 144, "ENCHANTED_COOKED_SALMON" },
                    { 145, "ENCHANTED_SEEDS" },
                    { 146, "LOG" },
                    { 147, "JACOBS_TICKET" },
                    { 148, "ENCHANTED_BONE_BLOCK" },
                    { 149, "GHAST_TEAR" },
                    { 150, "ENCHANTED_ENDER_PEARL" },
                    { 151, "UNSTABLE_FRAGMENT" },
                    { 152, "PURPLE_CANDY" },
                    { 153, "ENCHANTED_FERMENTED_SPIDER_EYE" },
                    { 155, "POLISHED_PUMPKIN" },
                    { 186, "GREEN_GIFT" },
                    { 187, "PACKED_ICE" },
                    { 188, "WATER_LILY" },
                    { 221, "SULPHUR" },
                    { 222, "NETHER_STALK" },
                    { 223, "DARK_BAIT" },
                    { 224, "ENCHANTED_CARROT" },
                    { 225, "ENCHANTED_PUMPKIN" },
                    { 226, "GRIFFIN_FEATHER" },
                    { 227, "ROTTEN_FLESH" },
                    { 228, "ENCHANTED_COOKED_FISH" },
                    { 229, "OBSIDIAN" },
                    { 230, "MINNOW_BAIT" },
                    { 231, "ENCHANTED_MAGMA_CREAM" },
                    { 232, "ENCHANTED_FIREWORK_ROCKET" },
                    { 233, "STARFALL" },
                    { 234, "LEATHER" },
                    { 235, "ENCHANTED_COOKED_MUTTON" },
                    { 236, "REFINED_TITANIUM" },
                    { 237, "ENCHANTED_RABBIT" },
                    { 238, "MUTANT_NETHER_STALK" },
                    { 239, "ENCHANTED_BREAD" },
                    { 240, "FUMING_POTATO_BOOK" },
                    { 241, "ENCHANTED_CHARCOAL" },
                    { 242, "ENCHANTED_BLAZE_POWDER" },
                    { 243, "SUMMONING_EYE" },
                    { 244, "FISH_BAIT" },
                    { 245, "SNOW_BLOCK" },
                    { 246, "ENCHANTED_BAKED_POTATO" },
                    { 247, "COMPACTOR" },
                    { 220, "RABBIT" },
                    { 219, "WHITE_GIFT" },
                    { 218, "RABBIT_HIDE" },
                    { 217, "ENCHANTED_OAK_LOG" },
                    { 189, "HAMSTER_WHEEL" },
                    { 190, "LOG_2" },
                    { 191, "ENCHANTED_OBSIDIAN" },
                    { 192, "ENCHANTED_COAL" },
                    { 193, "COAL" },
                    { 194, "ENCHANTED_QUARTZ" },
                    { 195, "ENCHANTED_COAL_BLOCK" },
                    { 196, "ENDER_PEARL" },
                    { 197, "WEREWOLF_SKIN" },
                    { 198, "ENCHANTED_PRISMARINE_CRYSTALS" },
                    { 199, "DAEDALUS_STICK" },
                    { 200, "ENCHANTED_WET_SPONGE" },
                    { 201, "ENCHANTED_RAW_FISH" },
                    { 126, "ENCHANTED_DARK_OAK_LOG" },
                    { 202, "ENDER_STONE" },
                    { 204, "QUARTZ" },
                    { 205, "RAW_BEEF" },
                    { 206, "JERRY_BOX_PURPLE" },
                    { 207, "ENCHANTED_EYE_OF_ENDER" },
                    { 208, "ECTOPLASM" },
                    { 209, "SUGAR_CANE" },
                    { 210, "MAGMA_CREAM" },
                    { 211, "SHARK_BAIT" },
                    { 212, "RED_GIFT" },
                    { 213, "ENCHANTED_RAW_BEEF" },
                    { 214, "JERRY_BOX_BLUE" },
                    { 215, "ENCHANTED_FEATHER" },
                    { 216, "ENCHANTED_SLIME_BLOCK" },
                    { 203, "FOUL_FLESH" },
                    { 125, "BLAZE_ROD" },
                    { 124, "SPONGE" },
                    { 123, "WHALE_BAIT" },
                    { 33, "MUTTON" },
                    { 34, "DIAMOND" },
                    { 35, "WISE_FRAGMENT" },
                    { 36, "SHARK_FIN" },
                    { 37, "COBBLESTONE" },
                    { 38, "REFINED_MITHRIL" },
                    { 39, "RAW_FISH" },
                    { 40, "SPIDER_EYE" },
                    { 41, "ENCHANTED_PUFFERFISH" },
                    { 42, "POTATO_ITEM" },
                    { 43, "ENCHANTED_HUGE_MUSHROOM_1" },
                    { 44, "REFINED_DIAMOND" },
                    { 45, "ENCHANTED_COBBLESTONE" },
                    { 46, "TIGHTLY_TIED_HAY_BALE" },
                    { 47, "ENCHANTED_HUGE_MUSHROOM_2" },
                    { 48, "PORK" },
                    { 49, "PRISMARINE_CRYSTALS" },
                    { 50, "ICE" },
                    { 51, "TIGER_SHARK_TOOTH" },
                    { 52, "HUGE_MUSHROOM_1" },
                    { 53, "ICE_BAIT" },
                    { 54, "HUGE_MUSHROOM_2" },
                    { 55, "LOG_2:1" },
                    { 56, "ENCHANTED_SNOW_BLOCK" },
                    { 57, "STRING" },
                    { 58, "GOLDEN_TOOTH" },
                    { 59, "HYPER_CATALYST" },
                    { 32, "ENCHANTED_MELON_BLOCK" },
                    { 31, "GRAND_EXP_BOTTLE" },
                    { 30, "RED_MUSHROOM" },
                    { 29, "ENCHANTED_SPIDER_EYE" },
                    { 1, "BROWN_MUSHROOM" },
                    { 2, "INK_SACK:4" },
                    { 3, "SPOOKY_SHARD" },
                    { 4, "TARANTULA_WEB" },
                    { 5, "CARROT_ITEM" },
                    { 6, "ENCHANTED_POTATO" },
                    { 7, "EXP_BOTTLE" },
                    { 8, "ENCHANTED_SLIME_BALL" },
                    { 9, "JERRY_BOX_GREEN" },
                    { 10, "ENCHANTED_RED_MUSHROOM" },
                    { 11, "ENCHANTED_GOLDEN_CARROT" },
                    { 12, "ENCHANTED_RABBIT_HIDE" },
                    { 13, "ENCHANTED_BIRCH_LOG" },
                    { 60, "RABBIT_FOOT" },
                    { 14, "ENCHANTED_GUNPOWDER" },
                    { 16, "ENCHANTED_SUGAR" },
                    { 17, "CACTUS" },
                    { 18, "ENCHANTED_BLAZE_ROD" },
                    { 19, "ENCHANTED_CAKE" },
                    { 20, "PUMPKIN" },
                    { 21, "ENCHANTED_BROWN_MUSHROOM" },
                    { 22, "WHEAT" },
                    { 23, "NURSE_SHARK_TOOTH" },
                    { 24, "ENCHANTED_RAW_SALMON" },
                    { 25, "ENCHANTED_GLISTERING_MELON" },
                    { 26, "PRISMARINE_SHARD" },
                    { 27, "ENCHANTED_EMERALD" },
                    { 28, "PROTECTOR_FRAGMENT" },
                    { 15, "ENCHANTED_MELON" },
                    { 248, "ENCHANTED_DIAMOND" },
                    { 61, "REDSTONE" },
                    { 63, "PUMPKIN_GUTS" },
                    { 96, "WOLF_TOOTH" },
                    { 97, "ENCHANTED_GRILLED_PORK" },
                    { 98, "ENCHANTED_NETHER_STALK" },
                    { 99, "ENCHANTED_REDSTONE_BLOCK" },
                    { 100, "ENCHANTED_QUARTZ_BLOCK" },
                    { 101, "ENCHANTED_ANCIENT_CLAW" },
                    { 102, "GREEN_CANDY" },
                    { 103, "ENCHANTED_REDSTONE" },
                    { 104, "ENCHANTED_REDSTONE_LAMP" },
                    { 105, "GREAT_WHITE_SHARK_TOOTH" },
                    { 106, "GRAVEL" },
                    { 107, "MELON" },
                    { 108, "ENCHANTED_PACKED_ICE" },
                    { 109, "ENCHANTED_LAVA_BUCKET" },
                    { 110, "RAW_FISH:3" },
                    { 111, "ENCHANTED_PRISMARINE_SHARD" },
                    { 112, "ENCHANTED_IRON_BLOCK" },
                    { 113, "RECOMBOBULATOR_3000" },
                    { 114, "ENCHANTED_CARROT_STICK" },
                    { 115, "BONE" },
                    { 116, "RAW_FISH:2" },
                    { 117, "RAW_FISH:1" },
                    { 118, "REVENANT_FLESH" },
                    { 119, "ENCHANTED_PORK" },
                    { 120, "ENCHANTED_GLOWSTONE" },
                    { 121, "FEATHER" },
                    { 122, "NETHERRACK" },
                    { 95, "ENCHANTED_SPRUCE_LOG" },
                    { 94, "ENCHANTED_ROTTEN_FLESH" },
                    { 93, "INK_SACK" },
                    { 92, "FLINT" },
                    { 64, "ENCHANTED_CACTUS_GREEN" },
                    { 65, "BOOSTER_COOKIE" },
                    { 66, "ENCHANTED_CARROT_ON_A_STICK" },
                    { 67, "ENCHANTED_COOKIE" },
                    { 68, "ENCHANTED_LAPIS_LAZULI_BLOCK" },
                    { 69, "ENCHANTED_ENDSTONE" },
                    { 70, "COLOSSAL_EXP_BOTTLE" },
                    { 71, "ENCHANTED_SAND" },
                    { 72, "ENCHANTED_STRING" },
                    { 73, "STRONG_FRAGMENT" },
                    { 74, "SLIME_BALL" },
                    { 75, "ENCHANTED_ACACIA_LOG" },
                    { 76, "HOLY_FRAGMENT" },
                    { 62, "JERRY_BOX_GOLDEN" },
                    { 77, "SNOW_BALL" },
                    { 79, "SAND" },
                    { 80, "SOUL_FRAGMENT" },
                    { 81, "RAW_CHICKEN" },
                    { 82, "ANCIENT_CLAW" },
                    { 83, "ENCHANTED_GHAST_TEAR" },
                    { 84, "ENCHANTED_LAPIS_LAZULI" },
                    { 85, "ENCHANTED_COCOA" },
                    { 86, "CARROT_BAIT" },
                    { 87, "SEEDS" },
                    { 88, "ENCHANTED_LEATHER" },
                    { 89, "ENCHANTED_SPONGE" },
                    { 90, "ENCHANTED_SHARK_FIN" },
                    { 91, "HAY_BLOCK" },
                    { 78, "ENCHANTED_EGG" },
                    { 249, "BAZAAR_COOKIE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BazaarProductEntries");

            migrationBuilder.DropTable(
                name: "BazaarProductIDMappings");
        }
    }
}
