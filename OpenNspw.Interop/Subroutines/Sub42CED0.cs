// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines
{
	// scenario_9
	internal static class Sub42CED0
	{
		public static void Call(Emulator emulator)
		{
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Esp);
			emulator.Cpu.Esp = emulator.Cpu.And(emulator.Cpu.Esp, new Register8(0xF8/*-8*/));
			emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0AB5800/*3232454656*/));
			emulator.Cpu.Edi = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
			emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0xC0AC8400/*3232531456*/));
			emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0x409DB000/*1084076032*/));
			emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x0000EA60/*60000*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x0F/*15*/));
			emulator.Cpu.Push(new Register8(0x0C/*12*/));
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0AC8400/*3232531456*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
			emulator.Cpu.Push(new Register8(0x0F/*15*/));
			emulator.Cpu.Push(new Register8(0x0C/*12*/));
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0ADB000/*3232608256*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x0F/*15*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0AEDC00/*3232685056*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B00400/*3232760832*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B09A00/*3232799232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B13000/*3232837632*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1C600/*3232876032*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B25C00/*3232914432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B2F200/*3232952832*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x4095E000/*1083564032*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B96400/*1085891584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Push(new Register8(0x10/*16*/));
			emulator.Cpu.Push(new Register8(0x0A/*10*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x4095E000/*1083564032*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B9FA00/*1085929984*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Push(new Register8(0x10/*16*/));
			emulator.Cpu.Push(new Register8(0x0A/*10*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x4095E000/*1083564032*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BA9000/*1085968384*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Push(new Register8(0x0F/*15*/));
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B41E00/*1085545984*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B4B400/*1085584384*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B54A00/*1085622784*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487092/*4747410*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B5E000/*1085661184*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B67600/*1085699584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487094/*4747412*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487096/*4747414*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B70C00/*1085737984*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B7A200/*1085776384*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487098/*4747416*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x0048709A/*4747418*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B83800/*1085814784*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B8CE00/*1085853184*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x0048709C/*4747420*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x0048709E/*4747422*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B96400/*1085891584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Memory16[new Register32(0x004870A0/*4747424*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x000005DC/*1500*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Cpu.Edx = emulator.Cpu.Add(emulator.Cpu.Edx, new Register32(0x00001B58/*7000*/));
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000034/*52*/)]);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0BB5800/*3233503232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edx);
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x48/*72*/));
			emulator.Memory16[new Register32(0x004870D2/*4747474*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x00487520/*4748576*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x004870D4/*4747476*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x004870D6/*4747478*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x000005DC/*1500*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BB5800/*1086019584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Edx = emulator.Cpu.Add(emulator.Cpu.Edx, new Register32(0x00001B58/*7000*/));
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)]);
			emulator.Cpu.Push(emulator.Cpu.Edx);
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Memory16[new Register32(0x0048756A/*4748650*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x004879B8/*4749752*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x0048756C/*4748652*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x0048756E/*4748654*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
			emulator.Cpu.Push(new Register32(0x004415E0/*4462048*/));
			emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x34/*52*/));
			emulator.Cpu.Edi = emulator.Cpu.Pop32();
			emulator.Cpu.Esi = emulator.Cpu.Pop32();
			emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Pop32();
			return;

		}
	}
}