// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// rand
internal static class Sub436056
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[new Register32(0x00442250/*4465232*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Imul(emulator.Cpu.Eax, new Register32(0x000343FD/*214013*/));
		emulator.Cpu.Eax = emulator.Cpu.Add(emulator.Cpu.Eax, new Register32(0x00269EC3/*2531011*/));
		emulator.Memory32[new Register32(0x00442250/*4465232*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Sar(emulator.Cpu.Eax, new Register8(0x10/*16*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x00007FFF/*32767*/));
		return;

	}
}
