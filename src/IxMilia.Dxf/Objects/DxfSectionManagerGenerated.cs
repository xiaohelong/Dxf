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
    /// DxfSectionManager class
    /// </summary>
    public partial class DxfSectionManager : DxfObject, IDxfItemInternal
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.SectionManager; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2007; } }

        IEnumerable<DxfPointer> IDxfItemInternal.GetPointers()
        {
            foreach (var pointer in SectionEntitiesPointers.Pointers)
            {
                yield return pointer;
            }
        }

        IEnumerable<IDxfItemInternal> IDxfItemInternal.GetChildItems()
        {
            return ((IDxfItemInternal)this).GetPointers().Select(p => (IDxfItemInternal)p.Item);
        }
        internal DxfPointerList<DxfEntity> SectionEntitiesPointers { get; } = new DxfPointerList<DxfEntity>();

        public bool RequiresFullUpdate { get; set; }
        private int _sectionCount { get; set; }
        public IList<DxfEntity> SectionEntities { get { return SectionEntitiesPointers; } }

        public DxfSectionManager()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.RequiresFullUpdate = false;
            this._sectionCount = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbSectionManager"));
            pairs.Add(new DxfCodePair(70, BoolShort(this.RequiresFullUpdate)));
            pairs.Add(new DxfCodePair(90, SectionEntities.Count));
            pairs.AddRange(this.SectionEntitiesPointers.Pointers.Select(p => new DxfCodePair(330, DxfCommonConverters.UIntHandle(p.Handle))));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 70:
                    this.RequiresFullUpdate = BoolShort(pair.ShortValue);
                    break;
                case 90:
                    this._sectionCount = (pair.IntegerValue);
                    break;
                case 330:
                    this.SectionEntitiesPointers.Pointers.Add(new DxfPointer(DxfCommonConverters.UIntHandle(pair.StringValue)));
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
