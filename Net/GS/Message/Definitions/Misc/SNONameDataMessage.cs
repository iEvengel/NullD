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
using NullD.Core.GS.Common.Types.SNO;

namespace NullD.Net.GS.Message.Definitions.Misc
{
    [Message(Opcodes.SNONameDataMessage)]
    public class SNONameDataMessage : GameMessage
    {
        public SNOHandle Name;

        public SNONameDataMessage() : base(Opcodes.SNONameDataMessage) { }

        public override void Parse(GameBitBuffer buffer)
        {
            Name = new SNOHandle();
            Name.Parse(buffer);
        }

        public override void Encode(GameBitBuffer buffer)
        {
            Name.Encode(buffer);
        }

        public override void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("SNONameDataMessage:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            Name.AsText(b, pad);
            b.Append(' ', --pad);
            b.AppendLine("}");
        }


    }
}
