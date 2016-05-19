// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Entities;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfRenderEnvironment class
    /// </summary>
    public partial class DxfRenderEnvironment : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.RenderEnvironment; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2007; } }
        public int ClassVersion { get; set; }
        public bool IsFogEnabled { get; set; }
        public bool IsBackgroundFogEnabled { get; set; }
        public int FogColor_Red { get; set; }
        public int FogColor_Green { get; set; }
        public int FogColor_Blue { get; set; }
        public double NearFogDensityPercent { get; set; }
        public double FarFogDensityPercent { get; set; }
        public double NearClippingPlaneDistancePercent { get; set; }
        public double FarClippingPlaneDistancePercent { get; set; }
        public bool UseEnvironmentImage { get; set; }
        public string EnvironmentImageFileName { get; set; }

        public DxfRenderEnvironment()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.ClassVersion = 1;
            this.IsFogEnabled = false;
            this.IsBackgroundFogEnabled = false;
            this.FogColor_Red = 0;
            this.FogColor_Green = 0;
            this.FogColor_Blue = 0;
            this.NearFogDensityPercent = 0.0;
            this.FarFogDensityPercent = 0.0;
            this.NearClippingPlaneDistancePercent = 0.0;
            this.FarClippingPlaneDistancePercent = 1.0;
            this.UseEnvironmentImage = false;
            this.EnvironmentImageFileName = null;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbRenderEnvironment"));
            pairs.Add(new DxfCodePair(90, (this.ClassVersion)));
            pairs.Add(new DxfCodePair(290, (this.IsFogEnabled)));
            pairs.Add(new DxfCodePair(290, (this.IsBackgroundFogEnabled)));
            pairs.Add(new DxfCodePair(280, (short)(this.FogColor_Red)));
            pairs.Add(new DxfCodePair(280, (short)(this.FogColor_Green)));
            pairs.Add(new DxfCodePair(280, (short)(this.FogColor_Blue)));
            pairs.Add(new DxfCodePair(40, (this.NearFogDensityPercent)));
            pairs.Add(new DxfCodePair(40, (this.FarFogDensityPercent)));
            pairs.Add(new DxfCodePair(40, (this.NearClippingPlaneDistancePercent)));
            pairs.Add(new DxfCodePair(40, (this.FarClippingPlaneDistancePercent)));
            pairs.Add(new DxfCodePair(290, (this.UseEnvironmentImage)));
            pairs.Add(new DxfCodePair(1, (this.EnvironmentImageFileName)));
        }

        // This object has vales that share codes between properties and these counters are used to know which property to
        // assign to in TrySetPair() below.
        private int _code_40_index = 0; // shared by properties NearFogDensityPercent, FarFogDensityPercent, NearClippingPlaneDistancePercent, FarClippingPlaneDistancePercent
        private int _code_280_index = 0; // shared by properties FogColor_Red, FogColor_Green, FogColor_Blue
        private int _code_290_index = 0; // shared by properties IsFogEnabled, IsBackgroundFogEnabled, UseEnvironmentImage

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.EnvironmentImageFileName = (pair.StringValue);
                    break;
                case 40:
                    switch (_code_40_index)
                    {
                        case 0:
                            this.NearFogDensityPercent = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 1:
                            this.FarFogDensityPercent = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 2:
                            this.NearClippingPlaneDistancePercent = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 3:
                            this.FarClippingPlaneDistancePercent = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 40");
                            break;
                    }
                    break;
                case 90:
                    this.ClassVersion = (pair.IntegerValue);
                    break;
                case 280:
                    switch (_code_280_index)
                    {
                        case 0:
                            this.FogColor_Red = (pair.ShortValue);
                            _code_280_index++;
                            break;
                        case 1:
                            this.FogColor_Green = (pair.ShortValue);
                            _code_280_index++;
                            break;
                        case 2:
                            this.FogColor_Blue = (pair.ShortValue);
                            _code_280_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 280");
                            break;
                    }
                    break;
                case 290:
                    switch (_code_290_index)
                    {
                        case 0:
                            this.IsFogEnabled = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 1:
                            this.IsBackgroundFogEnabled = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 2:
                            this.UseEnvironmentImage = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 290");
                            break;
                    }
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
