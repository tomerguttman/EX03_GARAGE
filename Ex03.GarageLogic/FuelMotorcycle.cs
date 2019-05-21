﻿using System;

namespace Ex03_GarageLogic
{
    public class FuelMotorcycle : Motorcycle
    {
        private const eFuel k_TypeOfFuel = eFuel.Octane95;
        private const float k_MaxAmountOfFuel = 8;

        public FuelMotorcycle(string i_LicenseNumber) : base(i_LicenseNumber, k_MaxAmountOfFuel)
        {

        }

        public override string M_ModelName
        {
            get
            {
                return m_ModelName;
            }
            set
            {
                this.m_ModelName = value;
            }
        }

        public override string M_LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
            set
            {
                this.m_LicenseNumber = value;
            }
        }

        public override float M_EnergyPercentage
        {
            get
            {
                return m_EnergyPercentage;
            }
            set
            {
                this.m_EnergyPercentage = (m_CurrentAmountOfEnergy / m_MaxAmountOfEnergy) * 100;
            }
        }

        public override float M_CurrentAmountOfEnergy
        {
            get
            {
                return m_CurrentAmountOfEnergy;
            }
            set
            {
                this.m_CurrentAmountOfEnergy = value;
            }
        }

        public override float M_MaxAmountOfEnergy
        {
            get
            {
                return m_MaxAmountOfEnergy;
            }
            set
            {
                this.m_MaxAmountOfEnergy = value;
            }
        }

        public override Tire[] M_Tires
        {
            get
            {

                return m_Tires;
            }
            set
            {
                this.m_Tires = value;
            }
        }

        public eFuel K_TypeOfFuel
        {
            get
            {
                return k_TypeOfFuel;
            }
        }
    }
}