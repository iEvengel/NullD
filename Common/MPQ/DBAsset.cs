﻿/*
 * Copyright (C) 2011 - 2018 NullD project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Globalization;
using System.Threading;
using NullD.Core.GS.Common.Types.SNO;
using NullD.Common.Storage;

namespace NullD.Common.MPQ
{
    public class DBAsset : Asset
    {

        protected override bool SourceAvailable
        {
            get { return true; }
        }

        public DBAsset(SNOGroup group, Int32 snoId, string name)
            : base(group, snoId, name)
        {
        }

        public override void RunParser()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // Use invariant culture so that we don't hit pitfalls in non en/US systems with different number formats.
            _data = (FileFormat)PersistenceManager.Load(Parser, SNOId.ToString());
        }
    }
}
