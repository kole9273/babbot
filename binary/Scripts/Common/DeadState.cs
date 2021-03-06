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
using System;
using BabBot.Common;
using BabBot.Wow;
using BabBot.States;

namespace BabBot.Scripts.Common
{
    public class DeadState : State<WowPlayer>
    {
        protected Vector3D CorpseLocation;

        protected override void DoEnter(WowPlayer entity)
        {
            //on enter, get location of corpose
            CorpseLocation = entity.CorpseLocation;
            entity.RepopMe();
        }

        protected override void DoExecute(WowPlayer entity)
        {
            if (!entity.IsGhost) return;

            CorpseLocation = entity.CorpseLocation;
            //on execute, if the distance to our corpose is more than xx yards, we need to get there
            Output.Instance.Script(string.Format("Distance from corpse: {0}", entity.DistanceFromCorpse()), this);
            if (entity.DistanceFromCorpse() > GlobalBaseBotState.MinDistanceFromCorpse)
            {
                Output.Instance.Script("We're still too far, walking to corpse");
                // so we make a new move to state that will take us to our corpose
                var mtsCorpse = new MoveToState(CorpseLocation, GlobalBaseBotState.MinDistanceFromCorpse);

                //request that we move to this location
                CallChangeStateEvent(entity, mtsCorpse, true, false);

                return;
            }

            //we should now be close to our corpse so rez!
            // TODO: we should check that there's no delay time running before trying this
            Output.Instance.Script("Trying to resurrect", this);
            entity.RetrieveCorpse();

            /// TODO: We should also check the time we spent running around trying to recover our corpse
            /// and if it's over a certain threshold we should run back to the spirit healer and repop there

            // We're done, let's finish & exit
            Finish(entity);
            Exit(entity);
        }

        protected override void DoExit(WowPlayer entity)
        {
            //on exit, if there is a previous state, go back to it
            if (PreviousState != null)
            {
                CallChangeStateEvent(entity, PreviousState, false, false);
            }
        }

        protected override void DoFinish(WowPlayer entity)
        {
            //finish
        }
    }
}