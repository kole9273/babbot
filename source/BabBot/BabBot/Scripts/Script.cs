﻿/*
    This file is part of BabBot.

    BabBot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    BabBot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with BabBot.  If not, see <http://www.gnu.org/licenses/>.
  
    Copyright 2009 BabBot Team
*/
//css_import Paladin;
using System;
using System.Collections.Generic;
using BabBot.Bot;
using BabBot.Scripting;
using BabBot.Wow;

namespace BabBot.Scripts
{
    public class Script : IScript
    {
        private IHost parent;
        public IPlayerWrapper player;

        #region Configurable properties

        protected int MinMPPct = 80; // Minimum mana percentage to start drinking
        protected int MinHPPct = 80; // Minimum health percentage to start eating
        protected float MinMeleeDistance = 1.0f;
        protected float MaxMeleeDistance = 5.0f;
        protected float MinRangedDistance = 15.0f;
        protected float MaxRangedDistance = 25.0f;
        protected int HpPctEmergency = 25; // Minimum health percentage at which we call the emergency healing routine
        protected int HpPctPotion = 20; // Minimum health percentage at which we look for a health potion
        protected int MpPctPotion = 15; // Minimum mana percentage at which we look for a mana potion
        protected float MinDistanceFromCorpse = 20.0f; // Minimum distance from corpse after which we stop pathing looking for it
        protected float PullRange = 25.0f; // Distance at which we want to pull mobs
        protected UnitWrapper LastTarget;

        #endregion

        #region Lists

        protected PlayerActionList Actions;
        protected BindingList Bindings;
        protected SpellList HealingSpells;

        #endregion

        #region Classes
        protected SConsumable Consumable;
        #endregion

        #region IScript Members

        IHost IScript.Parent
        {
            set { parent = value; }
        }

        IPlayerWrapper IScript.Player
        {
            set { player = value; }
        }

        /// <summary>
        /// Local script initialization. Not much to do here at the moment
        /// </summary>
        void IScript.Init()
        {
            Console.WriteLine("Init() -- Begin");
            // Initialize all the lists
            Bindings = new BindingList();
            Actions = new PlayerActionList();
            HealingSpells = new SpellList();

            SConsumable.Instance.Init(player);
            Consumable = SConsumable.Instance;

            Console.WriteLine("Init() -- End");
        }

        /// <summary>
        /// Called at every update of the player data from the main thread of the bot
        /// aka the main routine
        /// </summary>
        void IScript.Update()
        {
            Console.WriteLine("Update() -- Begin");
            //Console.WriteLine("Current State: " + player.State());
            //switch (player.State())
            //{
            //    case PlayerState.PreMobSelection:
            //        break;
            //    case PlayerState.PostMobSelection:
            //        break;
            //    case PlayerState.Start:
            //        OnStart();
            //        break;
            //    case PlayerState.WayPointTimeout:
            //        break;
            //    case PlayerState.PreRest:
            //        break;
            //    case PlayerState.Rest:
            //        OnRest();
            //        break;
            //    case PlayerState.PostRest:
            //        break;
            //    case PlayerState.Dead:
            //        OnDead();
            //        break;
            //    case PlayerState.Graveyard:
            //        OnGraveyard();
            //        break;
            //    case PlayerState.PreResurrection:
            //        break;
            //    case PlayerState.PostResurrection:
            //        break;
            //    case PlayerState.PreLoot:
            //        break;
            //    case PlayerState.PostLoot:
            //        break;
            //    case PlayerState.PreCombat:
            //        OnPreCombat();
            //        break;
            //    case PlayerState.InCombat:
            //        OnInCombat();
            //        break;
            //    case PlayerState.PostCombat:
            //        OnPostCombat();
            //        break;
            //    case PlayerState.Sale:
            //        break;
            //    case PlayerState.Roaming:
            //        OnRoaming();
            //        break;
            //    case PlayerState.Stop:
            //        OnStop();
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}
            Console.WriteLine("Update() -- End");
        }

        /// <summary>
        /// This is called by the StateManager to check if we need to rest. It should be
        /// implemented by each class
        /// </summary>
        /// <returns>true if we need to rest</returns>
        public virtual bool NeedRest()
        {
            return false;
        }

        #endregion

        /// <summary>
        /// Called when we have attached ourselves to WoW's client or when we start botting.
        /// </summary>
        private void OnStart()
        {
            // No ideas for now :)
        }

        /// <summary>
        /// Called when we have detach from WoW's client or when we hit the stop button and stop botting.
        /// This state happens only once of course
        /// </summary>
        private void OnStop()
        {
            /// We stop movement just in case we're moving. Eventually we might want to stop fighting as well.
            player.Stop();
        }

        /// <summary>
        /// We are either a ghost or we just died
        /// </summary>
        private void OnDead()
        {
            /// We should run back to our corpse
            Console.WriteLine("OnDead()");
            if (!player.IsGhost())
            {
                Console.WriteLine("OnDead() - We are a ghost, let's try to repop");
                player.RepopMe();
                return;
            }
            Console.WriteLine(string.Format("OnDead() - Distance from corpse: {0}", player.DistanceFromCorpse()));
            if (player.DistanceFromCorpse() > MinDistanceFromCorpse)
            {
                Console.WriteLine("OnDead() -- Walking to corpse");
                player.MoveToCorpse(MinDistanceFromCorpse); // we accept being up to 20 yards away from the corpse
            } else
            {
                // We try to resurrect
                // TODO: we should check that there's no delay time running before trying this
                Console.WriteLine("OnDead() -- Trying to resurrect");
                player.RetrieveCorpse();
            }
        }

        /// <summary>
        /// We are near the graveyard (aka the spirit healer is in range)
        /// </summary>
        private void OnGraveyard()
        {
            /// If we managed to get to the graveyard and we have already run around
            /// like a crazy chicken without finding our own body, well.. it's time
            /// to resurrect at the spirit healer
        }

        /// <summary>
        /// We are roaming through the waypoints with nothing else to do
        /// </summary>
        private void OnRoaming()
        {
            /// This is where we should walk through the waypoints and 
            /// check what happens around us (like if there's anything to
            /// attack or anything attacking us, or if we run out of mana/health,
            /// or if we should rebuff something)
            /// 
            /// Right now we only walk through the waypoints as a proof of concept
            Console.WriteLine("OnRoaming() -- Walking to the next waypoint");
            player.WalkToNextWayPoint(WayPointType.Normal);
        }

        /// <summary>
        /// This happens when we are being attacked by some mobs or when we
        /// have found something to kill 
        /// </summary>
        private void OnPreCombat()
        {
            Console.WriteLine("OnPreCombat()");
            if (player.IsBeingAttacked())
            {
                Console.WriteLine("OnPreCombat() - We are being attacked");
                /// We are being attacked by a Mob. That means that we should fight back
                /// by finding the mob first of all
                if (player.SelectWhoIsAttackingUs())
                {
                    /// We found who is attacking us and we fight back (no rebuffing now)
                    /// (If everything is correct at this point the StateManager will take care
                    /// of switching to the OnCombat state)
                }
            }
            else
            {
                Console.WriteLine("OnPreCombat() - We are going to attack someone");
                if (player.EnemyInSight())
                {
                    // Face the closest enemy
                    Console.WriteLine("OnPreCombat() - Facing closest enemy (we should have a target now)");
                    player.FaceClosestEnemy();

                    // Let's check if we actually got it as our target
                    if (player.HasTarget())
                    {
                        Console.WriteLine("OnPreCombat() - Affirmative. We have a target");
                        /// Ok, we have the target, it's time to start attacking,
                        /// but first we rebuff and drink up just in case
                    }
                    else
                    {
                        // Let's try moving closer
                        Console.WriteLine("OnPreCombat() - Can't target. This should not happen :-P");
                    }
                }
            }
        }

        /// <summary>
        /// This routine gets called every time we end up fighting (because we pulled or 
        /// because a mob aggroed)
        /// This should be implemented in the spcific class script
        /// </summary>
        protected virtual void OnInCombat()
        {
            throw new NotImplementedException("OnInCombat() not implemented.");
        }

        /// <summary>
        /// This happens when a combat has just ended.
        /// </summary>
        protected virtual void OnPostCombat()
        {
            Console.WriteLine("OnPostCombat()");
            // We reset all actions listed as toggle
            foreach (var pair in Actions)
            {
                if (pair.Value.Toggle)
                {
                    pair.Value.Active = false;
                }
            }
            Console.WriteLine("OnPostCombat() - Adding last target to loot list");
            player.AddLastTargetToLootList();
            Console.WriteLine("OnPostCombat() Looting closest lootable mob");
            player.LootClosestLootableMob();

        }

        /// <summary>
        /// This is the routine called when we need resting
        /// This should be implemented in the spcific class script
        /// </summary>
        protected virtual void OnRest()
        {
            throw new NotImplementedException("OnRest() not implemented.");
        }

        #region Ranges

        protected float MinRanged()
        {
            return 11.0f + player.TargetBoundingRadius();
        }

        protected float MaxRanged()
        {
            if (player.TargetBoundingRadius() < 2.0f)
            {
                return 27.0f + player.TargetBoundingRadius();
            }
            return 29.0f;
        }

        protected float MinMelee()
        {
            return 1.0f + player.TargetBoundingRadius();
        }

        protected float MaxMelee()
        {
            if (player.TargetBoundingRadius() < 2.0f)
            {
                return 2.9f + player.TargetBoundingRadius();
            }
            return 4.5f;
        }


        #endregion

        #region Casting 

        protected bool IsCasting()
        {
            // TODO: We should also check if we're skinning, herbing etc as it counts as casting as well
            return player.IsCasting();
        }

        #endregion

        #region Common routines

        protected void Flee()
        {
            Flee(true);
        }

        protected void Flee(bool iToggle)
        {
            // TODO: implement
        }

        /// <summary>
        /// This method ensures that you've got the best target
        /// </summary>
        protected void TergetBestTarget() // aka BestTarget in Toon.iss
        {
            // TODO: implement
        }

        /// <summary>
        /// Check if you've got the best target
        /// </summary>
        /// <returns>true if you've got the best target</returns>
        protected bool TargetIsBestTarget()
        {
            // TODO: implement
            return true;
        }

        /// <summary>
        /// Returns the best target from the target collection
        /// </summary>
        /// <returns>the best target</returns>
        protected UnitWrapper BestTarget()
        {
            // TODO: implement
            return null;
        }

        /// <summary>
        /// Returns the next best target in the collection
        /// </summary>
        /// <returns>next best target</returns>
        protected UnitWrapper NextBestTarget()
        {
            // TODO: implement
            return null;
        }

        protected bool TargetIsNew()
        {
            // TODO: implement
            return true;
        }

        protected bool CanUseScroll()
        {
            return CanUseScroll("ANY");
        }

        protected bool CanUseScroll(string kind)
        {
            string scroll = CheckForScroll(kind);
            if (!string.IsNullOrEmpty(scroll))
            {
                return true;
            }
            return false;
        }

        protected string CheckForScroll()
        {
            return CheckForScroll("ANY");
        }

        protected string CheckForScroll(string kind)
        {
            if (kind == "ANY")
            {
                if (Consumable.HasScroll("Strength") && !player.HasBuff("Strength"))
                {
                    return "Strength";
                }
                if (Consumable.HasScroll("Agility") && !player.HasBuff("Agility"))
                {
                    return "Agility";
                }
                if (Consumable.HasScroll("Stamina") && !player.HasBuff("Stamina"))
                {
                    return "Stamina";
                }
                if (Consumable.HasScroll("Protection") && !player.HasBuff("Protection"))
                {
                    return "Protection";
                }
                if (Consumable.HasScroll("Spirit") && !player.HasBuff("Spirit"))
                {
                    return "Spirit";
                }
                if (Consumable.HasScroll("Intellect") && !player.HasBuff("Intellect"))
                {
                    return "Intellect";
                }
            }
            else if (kind == "Protection" || kind == "Armor")
            {
                if (Consumable.HasScroll("Protection") && !player.HasBuff("Armor"))
                {
                    return "Protection";
                }
            }
            else if (Consumable.HasScroll(kind) && !player.HasBuff(kind))
            {
                return kind;
            }
            return "";
        }

        protected void UseScroll()
        {
            UseScroll("ANY");
        }

        protected void UseScroll(string kind)
        {
            string scroll = CheckForScroll(kind);
            if (scroll != "")
            {
                Console.WriteLine(string.Format("Using scroll of {0}", kind));
                player.TargetMe();
                Consumable.UseScroll(kind);
                return;
            }
        }


        #endregion

        #region Sit & Stand

        protected bool IsSitting()
        {
            // This should prevent drowning
            if (player.IsSitting())
            {
                player.DoString("DescendStop()");
                return true;
            }
            player.DoString("DescendStop()");
            return false;
        }

        protected void Sit()
        {
            if (!IsSitting())
            {
                player.DoString("DoEmote(\"SIT\")");
                player.Wait(300);
            }
        }

        protected void Stand()
        {
            if (IsSitting())
            {
                player.DoString("DoEmote(\"STAND\")");
                player.Wait(300);
            }
        }

        #endregion

        #region Rest stuff



        protected bool NeedMana()
        {
            if (player.MpPct() < MinMPPct)
            {
                return true;
            }
            return false;
        }

        protected bool NeedHealth()
        {
            if (player.HpPct() < MinHPPct)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This should be implemented by the script of the corresponing player class and return whether
        /// the toon can cast healing spells or not
        /// </summary>
        /// <returns>true if the toon can cast healing spells</returns>
        protected virtual bool IsHealer()
        {
            return false;
        }

        protected bool CanSelfHeal()
        {
            /// We should also have a list of self healing spells with a priority on them
            /// and go through that list and see if we have the mana and if the spell is
            /// not on cooldown
            if (IsHealer())
            {
                return true;
            }
            return false;
        }

        protected virtual void SelfHeal()
        {
            
        }




        protected void Eat()
        {
            /// we should go through our list of food and use one of them
        }

        #endregion

        #region Consumables

        protected bool HasHealthPotion()
        {
            return false;
        }

        protected bool HasManaPotion()
        {
            return false;
        }

        
        #endregion
    }
}