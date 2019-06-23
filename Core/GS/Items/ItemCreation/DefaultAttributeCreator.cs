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

using NullD.Common.Helpers.Math;
using NullD.Net.GS.Message;
using NullD.Common.Helpers;

namespace NullD.Core.GS.Items.ItemCreation
{
    class DefaultAttributeCreator : IItemAttributeCreator
    {
        public void CreateAttributes(Item item)
        {
            item.Attributes[GameAttribute.Item_Quality_Level] = 1;
            item.Attributes[GameAttribute.Seed] = RandomHelper.Next(); //unchecked((int)2286800181);
        }
    }
}
