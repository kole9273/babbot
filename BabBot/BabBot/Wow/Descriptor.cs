﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BabBot.Wow
{
    public static class Descriptor
    {
        // Version: 3.0.9  Build number: 9551  Build date: Feb  3 2009

        /*----------------------------------
        WoW Offset Dumper 0.1 - IDC Script
        by kynox

        Credits:
        bobbysing, Patrick, Dominik, Azorbix
        -----------------------------------*/

        // Descriptors: 0x00FC3C98
        public enum eObjectFields : uint
        {
            OBJECT_FIELD_GUID = 0x0,
            OBJECT_FIELD_TYPE = 0x8,
            OBJECT_FIELD_ENTRY = 0xC,
            OBJECT_FIELD_SCALE_X = 0x10,
            OBJECT_FIELD_PADDING = 0x14,
            TOTAL_OBJECT_FIELDS = 0x5
        }

        // Descriptors: 0x00FC4030
        public enum eUnitFields : uint
        {
            UNIT_FIELD_CHARM = 0x0,
            UNIT_FIELD_SUMMON = 0x8,
            UNIT_FIELD_CRITTER = 0x10,
            UNIT_FIELD_CHARMEDBY = 0x18,
            UNIT_FIELD_SUMMONEDBY = 0x20,
            UNIT_FIELD_CREATEDBY = 0x28,
            UNIT_FIELD_TARGET = 0x30,
            UNIT_FIELD_CHANNEL_OBJECT = 0x38,
            UNIT_FIELD_BYTES_0 = 0x40,
            UNIT_FIELD_HEALTH = 0x44,
            UNIT_FIELD_POWER1 = 0x48,
            UNIT_FIELD_POWER2 = 0x4C,
            UNIT_FIELD_POWER3 = 0x50,
            UNIT_FIELD_POWER4 = 0x54,
            UNIT_FIELD_POWER5 = 0x58,
            UNIT_FIELD_POWER6 = 0x5C,
            UNIT_FIELD_POWER7 = 0x60,
            UNIT_FIELD_MAXHEALTH = 0x64,
            UNIT_FIELD_MAXPOWER1 = 0x68,
            UNIT_FIELD_MAXPOWER2 = 0x6C,
            UNIT_FIELD_MAXPOWER3 = 0x70,
            UNIT_FIELD_MAXPOWER4 = 0x74,
            UNIT_FIELD_MAXPOWER5 = 0x78,
            UNIT_FIELD_MAXPOWER6 = 0x7C,
            UNIT_FIELD_MAXPOWER7 = 0x80,
            UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER = 0x84,
            UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER = 0xA0,
            UNIT_FIELD_LEVEL = 0xBC,
            UNIT_FIELD_FACTIONTEMPLATE = 0xC0,
            UNIT_VIRTUAL_ITEM_SLOT_ID = 0xC4,
            UNIT_FIELD_FLAGS = 0xD0,
            UNIT_FIELD_FLAGS_2 = 0xD4,
            UNIT_FIELD_AURASTATE = 0xD8,
            UNIT_FIELD_BASEATTACKTIME = 0xDC,
            UNIT_FIELD_RANGEDATTACKTIME = 0xE4,
            UNIT_FIELD_BOUNDINGRADIUS = 0xE8,
            UNIT_FIELD_COMBATREACH = 0xEC,
            UNIT_FIELD_DISPLAYID = 0xF0,
            UNIT_FIELD_NATIVEDISPLAYID = 0xF4,
            UNIT_FIELD_MOUNTDISPLAYID = 0xF8,
            UNIT_FIELD_MINDAMAGE = 0xFC,
            UNIT_FIELD_MAXDAMAGE = 0x100,
            UNIT_FIELD_MINOFFHANDDAMAGE = 0x104,
            UNIT_FIELD_MAXOFFHANDDAMAGE = 0x108,
            UNIT_FIELD_BYTES_1 = 0x10C,
            UNIT_FIELD_PETNUMBER = 0x110,
            UNIT_FIELD_PET_NAME_TIMESTAMP = 0x114,
            UNIT_FIELD_PETEXPERIENCE = 0x118,
            UNIT_FIELD_PETNEXTLEVELEXP = 0x11C,
            UNIT_DYNAMIC_FLAGS = 0x120,
            UNIT_CHANNEL_SPELL = 0x124,
            UNIT_MOD_CAST_SPEED = 0x128,
            UNIT_CREATED_BY_SPELL = 0x12C,
            UNIT_NPC_FLAGS = 0x130,
            UNIT_NPC_EMOTESTATE = 0x134,
            UNIT_FIELD_STAT0 = 0x138,
            UNIT_FIELD_STAT1 = 0x13C,
            UNIT_FIELD_STAT2 = 0x140,
            UNIT_FIELD_STAT3 = 0x144,
            UNIT_FIELD_STAT4 = 0x148,
            UNIT_FIELD_POSSTAT0 = 0x14C,
            UNIT_FIELD_POSSTAT1 = 0x150,
            UNIT_FIELD_POSSTAT2 = 0x154,
            UNIT_FIELD_POSSTAT3 = 0x158,
            UNIT_FIELD_POSSTAT4 = 0x15C,
            UNIT_FIELD_NEGSTAT0 = 0x160,
            UNIT_FIELD_NEGSTAT1 = 0x164,
            UNIT_FIELD_NEGSTAT2 = 0x168,
            UNIT_FIELD_NEGSTAT3 = 0x16C,
            UNIT_FIELD_NEGSTAT4 = 0x170,
            UNIT_FIELD_RESISTANCES = 0x174,
            UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = 0x190,
            UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = 0x1AC,
            UNIT_FIELD_BASE_MANA = 0x1C8,
            UNIT_FIELD_BASE_HEALTH = 0x1CC,
            UNIT_FIELD_BYTES_2 = 0x1D0,
            UNIT_FIELD_ATTACK_POWER = 0x1D4,
            UNIT_FIELD_ATTACK_POWER_MODS = 0x1D8,
            UNIT_FIELD_ATTACK_POWER_MULTIPLIER = 0x1DC,
            UNIT_FIELD_RANGED_ATTACK_POWER = 0x1E0,
            UNIT_FIELD_RANGED_ATTACK_POWER_MODS = 0x1E4,
            UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = 0x1E8,
            UNIT_FIELD_MINRANGEDDAMAGE = 0x1EC,
            UNIT_FIELD_MAXRANGEDDAMAGE = 0x1F0,
            UNIT_FIELD_POWER_COST_MODIFIER = 0x1F4,
            UNIT_FIELD_POWER_COST_MULTIPLIER = 0x210,
            UNIT_FIELD_MAXHEALTHMODIFIER = 0x22C,
            UNIT_FIELD_HOVERHEIGHT = 0x230,
            UNIT_FIELD_PADDING = 0x234,
            TOTAL_UNIT_FIELDS = 0x59
        }

        // Descriptors: 0x00FC3D38
        public enum eItemFields : uint
        {
            ITEM_FIELD_OWNER = 0x0,
            ITEM_FIELD_CONTAINED = 0x8,
            ITEM_FIELD_CREATOR = 0x10,
            ITEM_FIELD_GIFTCREATOR = 0x18,
            ITEM_FIELD_STACK_COUNT = 0x20,
            ITEM_FIELD_DURATION = 0x24,
            ITEM_FIELD_SPELL_CHARGES = 0x28,
            ITEM_FIELD_FLAGS = 0x3C,
            ITEM_FIELD_ENCHANTMENT_1_1 = 0x40,
            ITEM_FIELD_ENCHANTMENT_1_3 = 0x48,
            ITEM_FIELD_ENCHANTMENT_2_1 = 0x4C,
            ITEM_FIELD_ENCHANTMENT_2_3 = 0x54,
            ITEM_FIELD_ENCHANTMENT_3_1 = 0x58,
            ITEM_FIELD_ENCHANTMENT_3_3 = 0x60,
            ITEM_FIELD_ENCHANTMENT_4_1 = 0x64,
            ITEM_FIELD_ENCHANTMENT_4_3 = 0x6C,
            ITEM_FIELD_ENCHANTMENT_5_1 = 0x70,
            ITEM_FIELD_ENCHANTMENT_5_3 = 0x78,
            ITEM_FIELD_ENCHANTMENT_6_1 = 0x7C,
            ITEM_FIELD_ENCHANTMENT_6_3 = 0x84,
            ITEM_FIELD_ENCHANTMENT_7_1 = 0x88,
            ITEM_FIELD_ENCHANTMENT_7_3 = 0x90,
            ITEM_FIELD_ENCHANTMENT_8_1 = 0x94,
            ITEM_FIELD_ENCHANTMENT_8_3 = 0x9C,
            ITEM_FIELD_ENCHANTMENT_9_1 = 0xA0,
            ITEM_FIELD_ENCHANTMENT_9_3 = 0xA8,
            ITEM_FIELD_ENCHANTMENT_10_1 = 0xAC,
            ITEM_FIELD_ENCHANTMENT_10_3 = 0xB4,
            ITEM_FIELD_ENCHANTMENT_11_1 = 0xB8,
            ITEM_FIELD_ENCHANTMENT_11_3 = 0xC0,
            ITEM_FIELD_ENCHANTMENT_12_1 = 0xC4,
            ITEM_FIELD_ENCHANTMENT_12_3 = 0xCC,
            ITEM_FIELD_PROPERTY_SEED = 0xD0,
            ITEM_FIELD_RANDOM_PROPERTIES_ID = 0xD4,
            ITEM_FIELD_ITEM_TEXT_ID = 0xC,//0xD8,
            ITEM_FIELD_DURABILITY = 0xDC,
            ITEM_FIELD_MAXDURABILITY = 0xE0,
            ITEM_FIELD_PAD = 0xE4,
            TOTAL_ITEM_FIELDS = 0x26
        }

        // Descriptors: 0x00FC4728
        public enum ePlayerFields : uint
        {
            PLAYER_DUEL_ARBITER = 0x0,
            PLAYER_FLAGS = 0x8,
            PLAYER_GUILDID = 0xC,
            PLAYER_GUILDRANK = 0x10,
            PLAYER_BYTES = 0x14,
            PLAYER_BYTES_2 = 0x18,
            PLAYER_BYTES_3 = 0x1C,
            PLAYER_DUEL_TEAM = 0x20,
            PLAYER_GUILD_TIMESTAMP = 0x24,
            PLAYER_QUEST_LOG_1_1 = 0x28,
            PLAYER_QUEST_LOG_1_2 = 0x2C,
            PLAYER_QUEST_LOG_1_3 = 0x30,
            PLAYER_QUEST_LOG_1_4 = 0x34,
            PLAYER_QUEST_LOG_2_1 = 0x38,
            PLAYER_QUEST_LOG_2_2 = 0x3C,
            PLAYER_QUEST_LOG_2_3 = 0x40,
            PLAYER_QUEST_LOG_2_4 = 0x44,
            PLAYER_QUEST_LOG_3_1 = 0x48,
            PLAYER_QUEST_LOG_3_2 = 0x4C,
            PLAYER_QUEST_LOG_3_3 = 0x50,
            PLAYER_QUEST_LOG_3_4 = 0x54,
            PLAYER_QUEST_LOG_4_1 = 0x58,
            PLAYER_QUEST_LOG_4_2 = 0x5C,
            PLAYER_QUEST_LOG_4_3 = 0x60,
            PLAYER_QUEST_LOG_4_4 = 0x64,
            PLAYER_QUEST_LOG_5_1 = 0x68,
            PLAYER_QUEST_LOG_5_2 = 0x6C,
            PLAYER_QUEST_LOG_5_3 = 0x70,
            PLAYER_QUEST_LOG_5_4 = 0x74,
            PLAYER_QUEST_LOG_6_1 = 0x78,
            PLAYER_QUEST_LOG_6_2 = 0x7C,
            PLAYER_QUEST_LOG_6_3 = 0x80,
            PLAYER_QUEST_LOG_6_4 = 0x84,
            PLAYER_QUEST_LOG_7_1 = 0x88,
            PLAYER_QUEST_LOG_7_2 = 0x8C,
            PLAYER_QUEST_LOG_7_3 = 0x90,
            PLAYER_QUEST_LOG_7_4 = 0x94,
            PLAYER_QUEST_LOG_8_1 = 0x98,
            PLAYER_QUEST_LOG_8_2 = 0x9C,
            PLAYER_QUEST_LOG_8_3 = 0xA0,
            PLAYER_QUEST_LOG_8_4 = 0xA4,
            PLAYER_QUEST_LOG_9_1 = 0xA8,
            PLAYER_QUEST_LOG_9_2 = 0xAC,
            PLAYER_QUEST_LOG_9_3 = 0xB0,
            PLAYER_QUEST_LOG_9_4 = 0xB4,
            PLAYER_QUEST_LOG_10_1 = 0xB8,
            PLAYER_QUEST_LOG_10_2 = 0xBC,
            PLAYER_QUEST_LOG_10_3 = 0xC0,
            PLAYER_QUEST_LOG_10_4 = 0xC4,
            PLAYER_QUEST_LOG_11_1 = 0xC8,
            PLAYER_QUEST_LOG_11_2 = 0xCC,
            PLAYER_QUEST_LOG_11_3 = 0xD0,
            PLAYER_QUEST_LOG_11_4 = 0xD4,
            PLAYER_QUEST_LOG_12_1 = 0xD8,
            PLAYER_QUEST_LOG_12_2 = 0xDC,
            PLAYER_QUEST_LOG_12_3 = 0xE0,
            PLAYER_QUEST_LOG_12_4 = 0xE4,
            PLAYER_QUEST_LOG_13_1 = 0xE8,
            PLAYER_QUEST_LOG_13_2 = 0xEC,
            PLAYER_QUEST_LOG_13_3 = 0xF0,
            PLAYER_QUEST_LOG_13_4 = 0xF4,
            PLAYER_QUEST_LOG_14_1 = 0xF8,
            PLAYER_QUEST_LOG_14_2 = 0xFC,
            PLAYER_QUEST_LOG_14_3 = 0x100,
            PLAYER_QUEST_LOG_14_4 = 0x104,
            PLAYER_QUEST_LOG_15_1 = 0x108,
            PLAYER_QUEST_LOG_15_2 = 0x10C,
            PLAYER_QUEST_LOG_15_3 = 0x110,
            PLAYER_QUEST_LOG_15_4 = 0x114,
            PLAYER_QUEST_LOG_16_1 = 0x118,
            PLAYER_QUEST_LOG_16_2 = 0x11C,
            PLAYER_QUEST_LOG_16_3 = 0x120,
            PLAYER_QUEST_LOG_16_4 = 0x124,
            PLAYER_QUEST_LOG_17_1 = 0x128,
            PLAYER_QUEST_LOG_17_2 = 0x12C,
            PLAYER_QUEST_LOG_17_3 = 0x130,
            PLAYER_QUEST_LOG_17_4 = 0x134,
            PLAYER_QUEST_LOG_18_1 = 0x138,
            PLAYER_QUEST_LOG_18_2 = 0x13C,
            PLAYER_QUEST_LOG_18_3 = 0x140,
            PLAYER_QUEST_LOG_18_4 = 0x144,
            PLAYER_QUEST_LOG_19_1 = 0x148,
            PLAYER_QUEST_LOG_19_2 = 0x14C,
            PLAYER_QUEST_LOG_19_3 = 0x150,
            PLAYER_QUEST_LOG_19_4 = 0x154,
            PLAYER_QUEST_LOG_20_1 = 0x158,
            PLAYER_QUEST_LOG_20_2 = 0x15C,
            PLAYER_QUEST_LOG_20_3 = 0x160,
            PLAYER_QUEST_LOG_20_4 = 0x164,
            PLAYER_QUEST_LOG_21_1 = 0x168,
            PLAYER_QUEST_LOG_21_2 = 0x16C,
            PLAYER_QUEST_LOG_21_3 = 0x170,
            PLAYER_QUEST_LOG_21_4 = 0x174,
            PLAYER_QUEST_LOG_22_1 = 0x178,
            PLAYER_QUEST_LOG_22_2 = 0x17C,
            PLAYER_QUEST_LOG_22_3 = 0x180,
            PLAYER_QUEST_LOG_22_4 = 0x184,
            PLAYER_QUEST_LOG_23_1 = 0x188,
            PLAYER_QUEST_LOG_23_2 = 0x18C,
            PLAYER_QUEST_LOG_23_3 = 0x190,
            PLAYER_QUEST_LOG_23_4 = 0x194,
            PLAYER_QUEST_LOG_24_1 = 0x198,
            PLAYER_QUEST_LOG_24_2 = 0x19C,
            PLAYER_QUEST_LOG_24_3 = 0x1A0,
            PLAYER_QUEST_LOG_24_4 = 0x1A4,
            PLAYER_QUEST_LOG_25_1 = 0x1A8,
            PLAYER_QUEST_LOG_25_2 = 0x1AC,
            PLAYER_QUEST_LOG_25_3 = 0x1B0,
            PLAYER_QUEST_LOG_25_4 = 0x1B4,
            PLAYER_VISIBLE_ITEM_1_CREATOR = 0x1B8,
            PLAYER_VISIBLE_ITEM_1_0 = 0x1C0,
            PLAYER_VISIBLE_ITEM_1_PROPERTIES = 0x1F4,
            PLAYER_VISIBLE_ITEM_1_SEED = 0x1F8,
            PLAYER_VISIBLE_ITEM_1_PAD = 0x1FC,
            PLAYER_VISIBLE_ITEM_2_CREATOR = 0x200,
            PLAYER_VISIBLE_ITEM_2_0 = 0x208,
            PLAYER_VISIBLE_ITEM_2_PROPERTIES = 0x23C,
            PLAYER_VISIBLE_ITEM_2_SEED = 0x240,
            PLAYER_VISIBLE_ITEM_2_PAD = 0x244,
            PLAYER_VISIBLE_ITEM_3_CREATOR = 0x248,
            PLAYER_VISIBLE_ITEM_3_0 = 0x250,
            PLAYER_VISIBLE_ITEM_3_PROPERTIES = 0x284,
            PLAYER_VISIBLE_ITEM_3_SEED = 0x288,
            PLAYER_VISIBLE_ITEM_3_PAD = 0x28C,
            PLAYER_VISIBLE_ITEM_4_CREATOR = 0x290,
            PLAYER_VISIBLE_ITEM_4_0 = 0x298,
            PLAYER_VISIBLE_ITEM_4_PROPERTIES = 0x2CC,
            PLAYER_VISIBLE_ITEM_4_SEED = 0x2D0,
            PLAYER_VISIBLE_ITEM_4_PAD = 0x2D4,
            PLAYER_VISIBLE_ITEM_5_CREATOR = 0x2D8,
            PLAYER_VISIBLE_ITEM_5_0 = 0x2E0,
            PLAYER_VISIBLE_ITEM_5_PROPERTIES = 0x314,
            PLAYER_VISIBLE_ITEM_5_SEED = 0x318,
            PLAYER_VISIBLE_ITEM_5_PAD = 0x31C,
            PLAYER_VISIBLE_ITEM_6_CREATOR = 0x320,
            PLAYER_VISIBLE_ITEM_6_0 = 0x328,
            PLAYER_VISIBLE_ITEM_6_PROPERTIES = 0x35C,
            PLAYER_VISIBLE_ITEM_6_SEED = 0x360,
            PLAYER_VISIBLE_ITEM_6_PAD = 0x364,
            PLAYER_VISIBLE_ITEM_7_CREATOR = 0x368,
            PLAYER_VISIBLE_ITEM_7_0 = 0x370,
            PLAYER_VISIBLE_ITEM_7_PROPERTIES = 0x3A4,
            PLAYER_VISIBLE_ITEM_7_SEED = 0x3A8,
            PLAYER_VISIBLE_ITEM_7_PAD = 0x3AC,
            PLAYER_VISIBLE_ITEM_8_CREATOR = 0x3B0,
            PLAYER_VISIBLE_ITEM_8_0 = 0x3B8,
            PLAYER_VISIBLE_ITEM_8_PROPERTIES = 0x3EC,
            PLAYER_VISIBLE_ITEM_8_SEED = 0x3F0,
            PLAYER_VISIBLE_ITEM_8_PAD = 0x3F4,
            PLAYER_VISIBLE_ITEM_9_CREATOR = 0x3F8,
            PLAYER_VISIBLE_ITEM_9_0 = 0x400,
            PLAYER_VISIBLE_ITEM_9_PROPERTIES = 0x434,
            PLAYER_VISIBLE_ITEM_9_SEED = 0x438,
            PLAYER_VISIBLE_ITEM_9_PAD = 0x43C,
            PLAYER_VISIBLE_ITEM_10_CREATOR = 0x440,
            PLAYER_VISIBLE_ITEM_10_0 = 0x448,
            PLAYER_VISIBLE_ITEM_10_PROPERTIES = 0x47C,
            PLAYER_VISIBLE_ITEM_10_SEED = 0x480,
            PLAYER_VISIBLE_ITEM_10_PAD = 0x484,
            PLAYER_VISIBLE_ITEM_11_CREATOR = 0x488,
            PLAYER_VISIBLE_ITEM_11_0 = 0x490,
            PLAYER_VISIBLE_ITEM_11_PROPERTIES = 0x4C4,
            PLAYER_VISIBLE_ITEM_11_SEED = 0x4C8,
            PLAYER_VISIBLE_ITEM_11_PAD = 0x4CC,
            PLAYER_VISIBLE_ITEM_12_CREATOR = 0x4D0,
            PLAYER_VISIBLE_ITEM_12_0 = 0x4D8,
            PLAYER_VISIBLE_ITEM_12_PROPERTIES = 0x50C,
            PLAYER_VISIBLE_ITEM_12_SEED = 0x510,
            PLAYER_VISIBLE_ITEM_12_PAD = 0x514,
            PLAYER_VISIBLE_ITEM_13_CREATOR = 0x518,
            PLAYER_VISIBLE_ITEM_13_0 = 0x520,
            PLAYER_VISIBLE_ITEM_13_PROPERTIES = 0x554,
            PLAYER_VISIBLE_ITEM_13_SEED = 0x558,
            PLAYER_VISIBLE_ITEM_13_PAD = 0x55C,
            PLAYER_VISIBLE_ITEM_14_CREATOR = 0x560,
            PLAYER_VISIBLE_ITEM_14_0 = 0x568,
            PLAYER_VISIBLE_ITEM_14_PROPERTIES = 0x59C,
            PLAYER_VISIBLE_ITEM_14_SEED = 0x5A0,
            PLAYER_VISIBLE_ITEM_14_PAD = 0x5A4,
            PLAYER_VISIBLE_ITEM_15_CREATOR = 0x5A8,
            PLAYER_VISIBLE_ITEM_15_0 = 0x5B0,
            PLAYER_VISIBLE_ITEM_15_PROPERTIES = 0x5E4,
            PLAYER_VISIBLE_ITEM_15_SEED = 0x5E8,
            PLAYER_VISIBLE_ITEM_15_PAD = 0x5EC,
            PLAYER_VISIBLE_ITEM_16_CREATOR = 0x5F0,
            PLAYER_VISIBLE_ITEM_16_0 = 0x5F8,
            PLAYER_VISIBLE_ITEM_16_PROPERTIES = 0x62C,
            PLAYER_VISIBLE_ITEM_16_SEED = 0x630,
            PLAYER_VISIBLE_ITEM_16_PAD = 0x634,
            PLAYER_VISIBLE_ITEM_17_CREATOR = 0x638,
            PLAYER_VISIBLE_ITEM_17_0 = 0x640,
            PLAYER_VISIBLE_ITEM_17_PROPERTIES = 0x674,
            PLAYER_VISIBLE_ITEM_17_SEED = 0x678,
            PLAYER_VISIBLE_ITEM_17_PAD = 0x67C,
            PLAYER_VISIBLE_ITEM_18_CREATOR = 0x680,
            PLAYER_VISIBLE_ITEM_18_0 = 0x688,
            PLAYER_VISIBLE_ITEM_18_PROPERTIES = 0x6BC,
            PLAYER_VISIBLE_ITEM_18_SEED = 0x6C0,
            PLAYER_VISIBLE_ITEM_18_PAD = 0x6C4,
            PLAYER_VISIBLE_ITEM_19_CREATOR = 0x6C8,
            PLAYER_VISIBLE_ITEM_19_0 = 0x6D0,
            PLAYER_VISIBLE_ITEM_19_PROPERTIES = 0x704,
            PLAYER_VISIBLE_ITEM_19_SEED = 0x708,
            PLAYER_VISIBLE_ITEM_19_PAD = 0x70C,
            PLAYER_CHOSEN_TITLE = 0x710,
            PLAYER_FIELD_PAD_0 = 0x714,
            PLAYER_FIELD_INV_SLOT_HEAD = 0x718,
            PLAYER_FIELD_PACK_SLOT_1 = 0x7D0,
            PLAYER_FIELD_BANK_SLOT_1 = 0x850,
            PLAYER_FIELD_BANKBAG_SLOT_1 = 0x930,
            PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = 0x968,
            PLAYER_FIELD_KEYRING_SLOT_1 = 0x9C8,
            PLAYER_FIELD_VANITYPET_SLOT_1 = 0xAC8,
            PLAYER_FIELD_CURRENCYTOKEN_SLOT_1 = 0xB58,
            PLAYER_FIELD_QUESTBAG_SLOT_1 = 0xC58,
            PLAYER_FARSIGHT = 0xD58,
            PLAYER__FIELD_KNOWN_TITLES = 0xD60,
            PLAYER__FIELD_KNOWN_TITLES1 = 0xD68,
            PLAYER_FIELD_KNOWN_CURRENCIES = 0xD70,
            PLAYER_XP = 0xD78,
            PLAYER_NEXT_LEVEL_XP = 0xD7C,
            PLAYER_SKILL_INFO_1_1 = 0xD80,
            PLAYER_CHARACTER_POINTS1 = 0x1380,
            PLAYER_CHARACTER_POINTS2 = 0x1384,
            PLAYER_TRACK_CREATURES = 0x1388,
            PLAYER_TRACK_RESOURCES = 0x138C,
            PLAYER_BLOCK_PERCENTAGE = 0x1390,
            PLAYER_DODGE_PERCENTAGE = 0x1394,
            PLAYER_PARRY_PERCENTAGE = 0x1398,
            PLAYER_EXPERTISE = 0x139C,
            PLAYER_OFFHAND_EXPERTISE = 0x13A0,
            PLAYER_CRIT_PERCENTAGE = 0x13A4,
            PLAYER_RANGED_CRIT_PERCENTAGE = 0x13A8,
            PLAYER_OFFHAND_CRIT_PERCENTAGE = 0x13AC,
            PLAYER_SPELL_CRIT_PERCENTAGE1 = 0x13B0,
            PLAYER_SHIELD_BLOCK = 0x13CC,
            PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE = 0x13D0,
            PLAYER_EXPLORED_ZONES_1 = 0x13D4,
            PLAYER_REST_STATE_EXPERIENCE = 0x15D4,
            PLAYER_FIELD_COINAGE = 0x15D8,
            PLAYER_FIELD_MOD_DAMAGE_DONE_POS = 0x15DC,
            PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = 0x15F8,
            PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = 0x1614,
            PLAYER_FIELD_MOD_HEALING_DONE_POS = 0x1630,
            PLAYER_FIELD_MOD_TARGET_RESISTANCE = 0x1634,
            PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE = 0x1638,
            PLAYER_FIELD_BYTES = 0x163C,
            PLAYER_AMMO_ID = 0x1640,
            PLAYER_SELF_RES_SPELL = 0x1644,
            PLAYER_FIELD_PVP_MEDALS = 0x1648,
            PLAYER_FIELD_BUYBACK_PRICE_1 = 0x164C,
            PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = 0x167C,
            PLAYER_FIELD_KILLS = 0x16AC,
            PLAYER_FIELD_TODAY_CONTRIBUTION = 0x16B0,
            PLAYER_FIELD_YESTERDAY_CONTRIBUTION = 0x16B4,
            PLAYER_FIELD_LIFETIME_HONORBALE_KILLS = 0x16B8,
            PLAYER_FIELD_BYTES2 = 0x16BC,
            PLAYER_FIELD_WATCHED_FACTION_INDEX = 0x16C0,
            PLAYER_FIELD_COMBAT_RATING_1 = 0x16C4,
            PLAYER_FIELD_ARENA_TEAM_INFO_1_1 = 0x1728,
            PLAYER_FIELD_HONOR_CURRENCY = 0x1770,
            PLAYER_FIELD_ARENA_CURRENCY = 0x1774,
            PLAYER_FIELD_MAX_LEVEL = 0x1778,
            PLAYER_FIELD_DAILY_QUESTS_1 = 0x177C,
            PLAYER_RUNE_REGEN_1 = 0x17E0,
            PLAYER_NO_REAGENT_COST_1 = 0x17F0,
            PLAYER_FIELD_GLYPH_SLOTS_1 = 0x17FC,
            PLAYER_FIELD_GLYPHS_1 = 0x181C,
            PLAYER_GLYPHS_ENABLED = 0x183C,
            TOTAL_PLAYER_FIELDS = 0x10D
        }

        // Descriptors: 0x00FC3CFC
        public enum eContainerFields : uint
        {
            CONTAINER_FIELD_NUM_SLOTS = 0x0,
            CONTAINER_ALIGN_PAD = 0x4,
            CONTAINER_FIELD_SLOT_1 = 0x8,
            TOTAL_CONTAINER_FIELDS = 0x3
        }

        // Descriptors: 0x00FC5C30
        public enum eGameObjectFields : uint
        {
            GAMEOBJECT_DISPLAYID = 0x8,
            GAMEOBJECT_FLAGS = 0xC,
            GAMEOBJECT_ROTATION = 0x10,
            GAMEOBJECT_PARENTROTATION = 0x18,
            GAMEOBJECT_POS_X = 0x28,
            GAMEOBJECT_POS_Y = 0x2C,
            GAMEOBJECT_POS_Z = 0x30,
            GAMEOBJECT_FACING = 0x34,
            GAMEOBJECT_DYNAMIC = 0x38,
            GAMEOBJECT_FACTION = 0x3C,
            GAMEOBJECT_LEVEL = 0x40,
            GAMEOBJECT_BYTES_1 = 0x44,
            TOTAL_GAMEOBJECT_FIELDS = 0xC
        }

        // Descriptors: 0x00FC5D38
        public enum eDynamicObjectFields : uint
        {
            DYNAMICOBJECT_CASTER = 0x0,
            DYNAMICOBJECT_BYTES = 0x8,
            DYNAMICOBJECT_SPELLID = 0xC,
            DYNAMICOBJECT_RADIUS = 0x10,
            DYNAMICOBJECT_POS_X = 0x14,
            DYNAMICOBJECT_POS_Y = 0x18,
            DYNAMICOBJECT_POS_Z = 0x1C,
            DYNAMICOBJECT_FACING = 0x20,
            DYNAMICOBJECT_CASTTIME = 0x24,
            TOTAL_DYNAMICOBJECT_FIELDS = 0x9
        }

        // Descriptors: 0x00FC5DF0
        public enum eCorpseFields : uint
        {
            CORPSE_FIELD_OWNER = 0x0,
            CORPSE_FIELD_PARTY = 0x8,
            CORPSE_FIELD_FACING = 0x10,
            CORPSE_FIELD_POS_X = 0x14,
            CORPSE_FIELD_POS_Y = 0x18,
            CORPSE_FIELD_POS_Z = 0x1C,
            CORPSE_FIELD_DISPLAY_ID = 0x20,
            CORPSE_FIELD_ITEM = 0x24,
            CORPSE_FIELD_BYTES_1 = 0x70,
            CORPSE_FIELD_BYTES_2 = 0x74,
            CORPSE_FIELD_GUILD = 0x78,
            CORPSE_FIELD_FLAGS = 0x7C,
            CORPSE_FIELD_DYNAMIC_FLAGS = 0x80,
            CORPSE_FIELD_PAD = 0x84,
            TOTAL_CORPSE_FIELDS = 0xE
        }
    }
}