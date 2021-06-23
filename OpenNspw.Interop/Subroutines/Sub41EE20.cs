// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines
{
	// set_new_unit
	internal static class Sub41EE20
	{
		public static void Call(Emulator emulator)
		{
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Esp);
			emulator.Cpu.Esp = emulator.Cpu.And(emulator.Cpu.Esp, new Register8(0xF8/*-8*/));
			emulator.Cpu.Push(emulator.Cpu.Ecx);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x0000000C/*12*/)]);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Cmp(emulator.Cpu.Eax, new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
			if (emulator.Cpu.Je) goto loc_41EE49;
			emulator.Cpu.Cmp(emulator.Cpu.Eax, new Register8(0x07/*7*/));
			if (emulator.Cpu.Je) goto loc_41EE49;
			emulator.Cpu.Cmp(emulator.Cpu.Eax, new Register8(0x09/*9*/));
			if (emulator.Cpu.Je) goto loc_41EE49;
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Cpu.Ebx);
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000000C/*12*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
			goto loc_41EE55;

			loc_41EE49:
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000000C/*12*/)] = emulator.Cpu.Mov(new Register32(0x00000002/*2*/));
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000000C/*12*/)]);

			loc_41EE55:
			emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000008/*8*/)], emulator.Cpu.Ebx);
			if (emulator.Cpu.Jne) goto loc_41EE71;
			emulator.Cpu.Cmp(emulator.Cpu.Eax, emulator.Cpu.Ebx);
			if (emulator.Cpu.Jne) goto loc_41EE65;
			emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000014/*20*/));
			goto loc_41EE8B;

			loc_41EE65:
			emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000029/*41*/));
			emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000046/*70*/));
			goto loc_41EE8B;

			loc_41EE71:
			emulator.Cpu.Cmp(emulator.Cpu.Eax, emulator.Cpu.Ebx);
			if (emulator.Cpu.Jne) goto loc_41EE81;
			emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000015/*21*/));
			emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000028/*40*/));
			goto loc_41EE8B;

			loc_41EE81:
			emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000047/*71*/));
			emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000064/*100*/));

			loc_41EE8B:
			emulator.Cpu.Cmp(emulator.Cpu.Ebx, emulator.Cpu.Eax);
			if (emulator.Cpu.Jg) goto loc_41EEB3;
			emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ebx + emulator.Cpu.Ebx * new Register32(4));
			emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
			emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
			emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Ebx);
			emulator.Cpu.Esi = emulator.Cpu.Xor(emulator.Cpu.Esi, emulator.Cpu.Esi);
			emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx * new Register32(8) + new Register32(0x004916A0/*4789920*/));

			loc_41EEA3:
			emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Ecx], emulator.Cpu.Si);
			if (emulator.Cpu.Je) goto loc_41EEBC;
			emulator.Cpu.Ebx = emulator.Cpu.Inc(emulator.Cpu.Ebx);
			emulator.Cpu.Ecx = emulator.Cpu.Add(emulator.Cpu.Ecx, new Register32(0x00000598/*1432*/));
			emulator.Cpu.Cmp(emulator.Cpu.Ebx, emulator.Cpu.Eax);
			if (emulator.Cpu.Jle) goto loc_41EEA3;

			loc_41EEB3:
			emulator.Cpu.Eax = emulator.Cpu.Xor(emulator.Cpu.Eax, emulator.Cpu.Eax);
			emulator.Cpu.Edi = emulator.Cpu.Pop32();
			emulator.Cpu.Esi = emulator.Cpu.Pop32();
			emulator.Cpu.Ebx = emulator.Cpu.Pop32();
			emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Pop32();
			return;

			loc_41EEBC:
			emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Ebx + emulator.Cpu.Ebx * new Register32(4));
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000010/*16*/));
			emulator.Cpu.Edx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(8));
			emulator.Cpu.Edx = emulator.Cpu.Shl(emulator.Cpu.Edx, new Register8(0x02/*2*/));
			emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, emulator.Cpu.Ebx);
			emulator.Cpu.Edx = emulator.Cpu.Shl(emulator.Cpu.Edx, new Register8(0x03/*3*/));
			emulator.Cpu.Eax = emulator.Cpu.Xor(emulator.Cpu.Eax, emulator.Cpu.Eax);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x004916A0/*4789920*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916A8/*4789928*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916AC/*4789932*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B0/*4789936*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B4/*4789940*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B8/*4789944*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916BC/*4789948*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Cpu.Edi = emulator.Cpu.Lea(emulator.Cpu.Edx + new Register32(0x004916C4/*4789956*/));
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x004916C0/*4789952*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			// TODO: f3
			// TODO: ab
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491704/*4790020*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491708/*4790024*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491710/*4790032*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491714/*4790036*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491718/*4790040*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x0049171C/*4790044*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491730/*4790064*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491734/*4790068*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491748/*4790088*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x0049174C/*4790092*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491740/*4790080*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491744/*4790084*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491738/*4790072*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x0049173C/*4790076*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491728/*4790056*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x0049172C/*4790060*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491750/*4790096*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B64/*4791140*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B60/*4791136*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B70/*4791152*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B74/*4791156*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B68/*4791144*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B6C/*4791148*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x00491B88/*4791176*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x00491B8A/*4791178*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x00491B8C/*4791180*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x00491B8E/*4791182*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Edx + new Register32(0x00491BB8/*4791224*/));
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000008/*8*/));

			loc_41EFC2:
			emulator.Memory32[emulator.Cpu.Eax + new Register32(0x000000E0/*224*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Eax] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory32[emulator.Cpu.Eax + new Register32(0x00000020/*32*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, new Register8(0x04/*4*/));
			emulator.Cpu.Ecx = emulator.Cpu.Dec(emulator.Cpu.Ecx);
			if (emulator.Cpu.Jne) goto loc_41EFC2;
			emulator.Cpu.Ax = emulator.Cpu.Mov(emulator.Memory16[emulator.Cpu.Ebp + new Register32(0x00000008/*8*/)]);
			emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000010/*16*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491BFC/*4791292*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory16[emulator.Cpu.Edx + new Register32(0x004916A0/*4789920*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000014/*20*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916A8/*4789928*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
			emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000018/*24*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916AC/*4789932*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x0000001C/*28*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B0/*4789936*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
			emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000000C/*12*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B4/*4789940*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x0000000C/*12*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916B8/*4789944*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
			emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000020/*32*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x004916BC/*4789948*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Ebp + new Register32(0x00000024/*36*/)]);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491710/*4790032*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491714/*4790036*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491728/*4790056*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Memory16[emulator.Cpu.Ebx * new Register32(2) + new Register32(0x00489AE0/*4758240*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x0049172C/*4790060*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Memory16[emulator.Cpu.Ebx * new Register32(2) + new Register32(0x00489CE0/*4758752*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory32[emulator.Cpu.Edx + new Register32(0x00491B60/*4791136*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
			emulator.Cpu.Call(new Register32(0x0041E150/*4317520*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x04/*4*/));
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Cpu.Ebx);
			emulator.Cpu.Edi = emulator.Cpu.Pop32();
			emulator.Cpu.Esi = emulator.Cpu.Pop32();
			emulator.Cpu.Ebx = emulator.Cpu.Pop32();
			emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Pop32();
			return;

		}
	}
}