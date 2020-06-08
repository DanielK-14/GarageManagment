﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectricEngine : Engine
    {
        public ElectricEngine(float i_MaximumEnergySourceCapacity)
            : base(Engine.eEngineType.Electric, i_MaximumEnergySourceCapacity) { }
        
        public bool ReCharge(float i_HoursToAdd)
        {
            bool valid;
            if(i_HoursToAdd + m_RemainingEnergy > m_MaximumCapacity)
            {
                throw new ValueOutOfRangeException(m_MaximumCapacity, 0);
            }
            else
            {
                Remaining = Remaining + i_HoursToAdd;
                valid = true;
            }

            return valid;
        }

        public override List<string> RequiredInfoForCreation()
        {
            List<string> requiredInfo = new List<string>();
            requiredInfo.Add(string.Format("Please enter BATTERY ENERGY AMOUNT LEFT (MAXIMUM: {0}): ", m_MaximumCapacity));

            return requiredInfo;
        }
    }
}
