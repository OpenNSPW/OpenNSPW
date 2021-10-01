// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// set_new_unit_plane
internal static class Sub41F060
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000004/*4*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x68/*104*/));
		emulator.Cpu.Cmp(emulator.Cpu.Eax, emulator.Cpu.Edx);
		if (emulator.Cpu.Jne) goto loc_41F07F;
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000029/*41*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000000/*0*/)] = emulator.Cpu.Mov(new Register32(0x00000046/*70*/));
		goto loc_41F08C;

	loc_41F07F:
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000047/*71*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000000/*0*/)] = emulator.Cpu.Mov(new Register32(0x00000064/*100*/));

	loc_41F08C:
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000000/*0*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Xor(emulator.Cpu.Ebp, emulator.Cpu.Ebp);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Cmp(emulator.Cpu.Eax, emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Cpu.Eax);
		if (emulator.Cpu.Jg) goto loc_41F211;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Esi = emulator.Cpu.Lea(emulator.Cpu.Ecx * new Register32(8) + new Register32(0x004916A0/*4789920*/));

	loc_41F0B2:
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000008C/*140*/)], emulator.Cpu.Ebp);
		if (emulator.Cpu.Je) goto loc_41F21C;
		emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Esi], emulator.Cpu.Bp);
		if (emulator.Cpu.Jne) goto loc_41F1FE;
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000018/*24*/));
		emulator.Cpu.Eax = emulator.Cpu.Xor(emulator.Cpu.Eax, emulator.Cpu.Eax);
		emulator.Cpu.Edi = emulator.Cpu.Lea(emulator.Cpu.Esp + new Register32(0x00000018/*24*/));
		// TODO: f3
		// TODO: ab
		emulator.Cpu.Ecx = emulator.Cpu.Movsx(emulator.Memory16[new Register32(0x00443A90/*4471440*/)]);
		emulator.Cpu.Cmp(emulator.Cpu.Ecx, emulator.Cpu.Edx);
		if (emulator.Cpu.Jl) goto loc_41F111;
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00491C50/*4791376*/));

	loc_41F0E5:
		emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Eax + new Register32(0x000000E8/*232*/)], emulator.Cpu.Bp);
		if (emulator.Cpu.Je) goto loc_41F109;
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Eax], new Register8(0x02/*2*/));
		if (emulator.Cpu.Jne) goto loc_41F109;
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000088/*136*/)]);
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Eax + new Register32(0x00000010/*16*/)], emulator.Cpu.Edi);
		if (emulator.Cpu.Jne) goto loc_41F109;
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Eax + new Register32(0x0000000C/*12*/)], new Register8(0x02/*2*/));
		if (emulator.Cpu.Jne) goto loc_41F109;
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Eax + new Register32(0x00000014/*20*/)]);
		emulator.Memory32[emulator.Cpu.Esp + emulator.Cpu.Edi * new Register32(4) + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);

	loc_41F109:
		emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, new Register32(0x00000598/*1432*/));
		emulator.Cpu.Ecx = emulator.Cpu.Dec(emulator.Cpu.Ecx);
		if (emulator.Cpu.Jne) goto loc_41F0E5;

		loc_41F111:
		emulator.Cpu.Eax = emulator.Cpu.Xor(emulator.Cpu.Eax, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Esp + new Register32(0x00000018/*24*/));

	loc_41F117:
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Ecx], emulator.Cpu.Ebp);
		if (emulator.Cpu.Je) goto loc_41F126;
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Add(emulator.Cpu.Ecx, new Register8(0x04/*4*/));
		emulator.Cpu.Cmp(emulator.Cpu.Eax, new Register8(0x18/*24*/));
		if (emulator.Cpu.Jl) goto loc_41F117;
		goto loc_41F12A;

	loc_41F126:
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);

	loc_41F12A:
		emulator.Cpu.Ax = emulator.Cpu.Mov(emulator.Memory16[emulator.Cpu.Esp + new Register32(0x0000007C/*124*/)]);
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000080/*128*/)]);
		emulator.Cpu.Cx = emulator.Cpu.Mov(emulator.Memory16[emulator.Cpu.Esp + new Register32(0x00000084/*132*/)]);
		emulator.Memory16[emulator.Cpu.Esi] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000008/*8*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x0000000C/*12*/)] = emulator.Cpu.Mov(new Register32(0x4086D000/*1082576896*/));
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000002/*2*/));
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000014/*20*/)] = emulator.Cpu.Mov(new Register32(0x4062C000/*1080213504*/));
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x0000001C/*28*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory16[emulator.Cpu.Esi + new Register32(0x00000020/*32*/)] = emulator.Cpu.Mov(emulator.Cpu.Cx);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)]);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000024/*36*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000088/*136*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000028/*40*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x0000002C/*44*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000030/*48*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000034/*52*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000038/*56*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Call(new Register32(0x00416F40/*4288320*/));
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x000000B0/*176*/)] = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000028/*40*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Edx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Edx = emulator.Cpu.Shl(emulator.Cpu.Edx, new Register8(0x02/*2*/));
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Edx * new Register32(8) + new Register32(0x004916C8/*4789960*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Edx * new Register32(8) + new Register32(0x004916C8/*4789960*/));
		emulator.Cpu.Ecx = emulator.Cpu.Inc(emulator.Cpu.Ecx);
		emulator.Memory32[emulator.Cpu.Eax] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
		emulator.Cpu.Call(new Register32(0x0041E150/*4317520*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Cpu.Cmp(emulator.Cpu.Edi, new Register8(0x07/*7*/));
		if (emulator.Cpu.Je) goto loc_41F1EA;
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000090/*144*/)]);
		emulator.Cpu.Cmp(emulator.Cpu.Eax, new Register8(0x11/*17*/));
		if (emulator.Cpu.Jne) goto loc_41F1D8;
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000518/*1304*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x0000051C/*1308*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		goto loc_41F1EA;

	loc_41F1D8:
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000518/*1304*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esi + new Register32(0x00000528/*1320*/)]);
		emulator.Memory32[emulator.Cpu.Esi + new Register32(0x0000051C/*1308*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);

	loc_41F1EA:
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000008C/*140*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000008C/*140*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);

	loc_41F1FE:
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Cpu.Ebx = emulator.Cpu.Inc(emulator.Cpu.Ebx);
		emulator.Cpu.Esi = emulator.Cpu.Add(emulator.Cpu.Esi, new Register32(0x00000598/*1432*/));
		emulator.Cpu.Cmp(emulator.Cpu.Ebx, emulator.Cpu.Eax);
		if (emulator.Cpu.Jle) goto loc_41F0B2;

		loc_41F211:
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000008C/*140*/)]);
		emulator.Cpu.Cmp(emulator.Cpu.Eax, emulator.Cpu.Ebp);
		if (emulator.Cpu.Jne) goto loc_41F226;

		loc_41F21C:
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x68/*104*/));
		return;

	loc_41F226:
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		emulator.Cpu.Eax = emulator.Cpu.Neg(emulator.Cpu.Eax);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x68/*104*/));
		return;

	}
}
