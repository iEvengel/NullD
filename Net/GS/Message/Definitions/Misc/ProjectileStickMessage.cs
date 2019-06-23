/*
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

using System.Text;
using NullD.Core.GS.Common.Types.Math;
using NullD.Net.GS.Message.Fields;

namespace NullD.Net.GS.Message.Definitions.Misc
{
    [Message(Opcodes.ProjectileStickMessage)]
    public class ProjectileStickMessage : GameMessage
    {
        public Vector3D Field0;
        public int Field1;
        public int /* sno */ Field2;

        public override void Parse(GameBitBuffer buffer)
        {
            Field0 = new Vector3D();
            Field0.Parse(buffer);
            Field1 = buffer.ReadInt(32);
            Field2 = buffer.ReadInt(32);
        }

        public override void Encode(GameBitBuffer buffer)
        {
            Field0.Encode(buffer);
            buffer.WriteInt(32, Field1);
            buffer.WriteInt(32, Field2);
        }

        public override void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("ProjectileStickMessage:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            Field0.AsText(b, pad);
            b.Append(' ', pad); b.AppendLine("Field1: 0x" + Field1.ToString("X8") + " (" + Field1 + ")");
            b.Append(' ', pad); b.AppendLine("Field2: 0x" + Field2.ToString("X8"));
            b.Append(' ', --pad);
            b.AppendLine("}");
        }


    }
}