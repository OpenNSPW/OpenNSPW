// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// plane_in_cv
internal static class Sub416F00
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Edx = emulator.Cpu.Movsx(emulator.Memory16[new Register32(0x00443A90/*4471440*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Xor(emulator.Cpu.Eax, emulator.Cpu.Eax);
		emulator.Cpu.Cmp(emulator.Cpu.Edx, new Register8(0x01/*1*/));
		if (emulator.Cpu.Jl) goto loc_416F3A;
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000008/*8*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00491C50/*4791376*/));

	loc_416F18:
		emulator.Cpu.Cmp(emulator.Memory16[emulator.Cpu.Ecx + new Register32(0x000000E8/*232*/)], new Register8(0x00/*0*/));
		if (emulator.Cpu.Je) goto loc_416F30;
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Ecx], new Register8(0x02/*2*/));
		if (emulator.Cpu.Jne) goto loc_416F30;
		emulator.Cpu.Cmp(emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x0000000C/*12*/)], new Register8(0x02/*2*/));
		if (emulator.Cpu.Jne) goto loc_416F30;
		emulator.Cpu.Cmp(emulator.Cpu.Esi, emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00000010/*16*/)]);
		if (emulator.Cpu.Jne) goto loc_416F30;
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_416F30:
		emulator.Cpu.Ecx = emulator.Cpu.Add(emulator.Cpu.Ecx, new Register32(0x00000598/*1432*/));
		emulator.Cpu.Edx = emulator.Cpu.Dec(emulator.Cpu.Edx);
		if (emulator.Cpu.Jne) goto loc_416F18;
		emulator.Cpu.Esi = emulator.Cpu.Pop32();

	loc_416F3A:
		return;

	}
}
