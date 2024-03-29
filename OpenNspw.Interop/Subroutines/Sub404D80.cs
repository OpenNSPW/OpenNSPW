// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// sub_404D80
internal static class Sub404D80
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000004/*4*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(2));
		emulator.Cpu.Eax = emulator.Cpu.Shl(emulator.Cpu.Eax, new Register8(0x04/*4*/));
		emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, emulator.Cpu.Ecx);
		emulator.Cpu.Edi = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(2));
		emulator.Cpu.Edi = emulator.Cpu.Shl(emulator.Cpu.Edi, new Register8(0x02/*2*/));
		emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Edi * new Register32(2) + new Register32(0x00486BCE/*4746190*/)], new Register8(0x00/*0*/));
		if (emulator.Cpu.Je) goto loc_404DC0;
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(2));
		emulator.Cpu.Eax = emulator.Cpu.Shl(emulator.Cpu.Eax, new Register8(0x04/*4*/));
		emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, emulator.Cpu.Ecx);
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(2));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Eax * new Register32(8) + new Register32(0x00486BCE/*4746190*/));

	loc_404DB6:
		emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, new Register8(0x02/*2*/));
		emulator.Cpu.Ebx = emulator.Cpu.Inc(emulator.Cpu.Ebx);
		emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Eax], new Register8(0x00/*0*/));
		if (emulator.Cpu.Jne) goto loc_404DB6;

		loc_404DC0:
		emulator.Cpu.Ebx = emulator.Cpu.Dec(emulator.Cpu.Ebx);
		emulator.Cpu.Cmp(emulator.Cpu.Ebx, new Register8(0x01/*1*/));
		if (emulator.Cpu.Jle) goto loc_404E20;
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000012/*18*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Edx = emulator.Cpu.Inc(emulator.Cpu.Edx);
		emulator.Cpu.Cmp(emulator.Cpu.Edx, new Register8(0x01/*1*/));
		if (emulator.Cpu.Jl) goto loc_404E20;
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Edx);

	loc_404DDD:
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Idiv(emulator.Cpu.Ebx);
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Esi = emulator.Cpu.Inc(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Idiv(emulator.Cpu.Ebx);
		emulator.Cpu.Edx = emulator.Cpu.Inc(emulator.Cpu.Edx);
		emulator.Cpu.Cmp(emulator.Cpu.Esi, emulator.Cpu.Edx);
		if (emulator.Cpu.Je) goto loc_404E1B;
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Edi + emulator.Cpu.Esi * new Register32(1));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Edi + emulator.Cpu.Edx * new Register32(1));
		emulator.Cpu.Esi = emulator.Cpu.Movsx(emulator.Memory16[emulator.Cpu.Eax * new Register32(2) + new Register32(0x00486BCC/*4746188*/)]);
		emulator.Cpu.Dx = emulator.Cpu.Mov(emulator.Memory16[emulator.Cpu.Ecx * new Register32(2) + new Register32(0x00486BCC/*4746188*/)]);
		emulator.Memory16[emulator.Cpu.Eax * new Register32(2) + new Register32(0x00486BCC/*4746188*/)] = emulator.Cpu.Mov(emulator.Cpu.Dx);
		emulator.Memory16[emulator.Cpu.Ecx * new Register32(2) + new Register32(0x00486BCC/*4746188*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);

	loc_404E1B:
		emulator.Cpu.Ebp = emulator.Cpu.Dec(emulator.Cpu.Ebp);
		if (emulator.Cpu.Jne) goto loc_404DDD;
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();

	loc_404E20:
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		return;

	}
}
