﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNL.Automation.Server
{
    public enum TagQuality
    {
        Bad = 0,
        BadLowLimited = 1,
        BadHighLimited = 2,
        BadConstant = 3,
        BadConfigurationError = 4,
        BadConfigurationErrorLowLimited = 5,
        BadConfigurationErrorHighLimited = 6,
        BadConfigurationErrorConstant = 7,
        BadNotConnected = 8,
        BadNotConnectedLowLimited = 9,
        BadNotConnectedHighLimited = 10,
        BadNotConnectedConstant = 11,
        BadDeviceFailure = 12,
        BadDeviceFailureLowLimited = 13,
        BadDeviceFailureHighLimited = 14,
        BadDeviceFailureConstant = 15,
        BadSensorFailure = 16,
        BadSensorFailureLowLimited = 17,
        BadSensorFailureHighLimited = 18,
        BadSensorFailureConstant = 19,
        BadLastKnownValue = 20,
        BadLastKnownValueLowLimited = 21,
        BadLastKnownValueHighLimited = 22,
        BadLastKnownValueConstant = 23,
        BadCommFailure = 24,
        BadCommFailureLowLimited = 25,
        BadCommFailureHighLimited = 26,
        BadCommFailureConstant = 27,
        BadOutofService = 28,
        BadOutofServiceLowLimited = 29,
        BadOutofServiceHighLimited = 30,
        BadOutofServiceConstant = 31,
        BadWaitingforInitialData = 32,
        BadWaitingforInitialDataLowLimited = 33,
        BadWaitingforInitialDataHighLimited = 34,
        BadWaitingforInitialDataConstant = 35,
        Uncertain = 64,
        UncertainLowLimited = 65,
        UncertainHighLimited = 66,
        UncertainConstant = 67,
        UncertainLastUsableValue = 68,
        UncertainLastUsableValueLowLimited = 69,
        UncertainLastUsableValueHighLimited = 70,
        UncertainLastUsableValueConstant = 71,
        UncertainSensorNotAccurate = 80,
        UncertainSensorNotAccurateLowLimited = 81,
        UncertainSensorNotAccurateHighLimited = 82,
        UncertainSensorNotAccurateConstant = 83,
        UncertainEngineeringUnitsExceeded = 84,
        UncertainEngineeringUnitsExceededLowLimited = 85,
        UncertainEngineeringUnitsExceededHighLimited = 86,
        UncertainEngineeringUnitsExceededConstant = 87,
        UncertainSubNormal = 88,
        UncertainSubNormalLowLimited = 89,
        UncertainSubNormalHighLimited = 90,
        UncertainSubNormalConstant = 91,
        Good = 192,
        GoodLowLimited = 193,
        GoodHighLimited = 194,
        GoodConstant = 195,
        GoodLocalOverride = 216,
        GoodLocalOverrideLowLimited = 217,
        GoodLocalOverrideHighLimited = 218,
        GoodLocalOverrideConstant = 219
    }
}
