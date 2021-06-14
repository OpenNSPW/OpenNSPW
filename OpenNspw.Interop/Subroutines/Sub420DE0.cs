// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines
{
	// scenario_105
	internal static class Sub420DE0
	{
		public static void Call(Emulator emulator)
		{
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B27000/*3232919552*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0BDB000/*3233656832*/));
			emulator.Cpu.Edi = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x0C/*12*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
			emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0xC0B50400/*3233088512*/));
			emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0xC0B00400/*3232760832*/));
			emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x000DBBA0/*900000*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B19400/*3232863232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B57C00/*3233119232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B20C00/*3232893952*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B57C00/*3233119232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B50400/*3233088512*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B46E00/*3233050112*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B3D800/*3233011712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B34200/*3232973312*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B2AC00/*3232934912*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B1E400/*3232883712*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0B21600/*3232896512*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0868000/*3230040064*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BC2000/*1086070784*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x0C/*12*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
			if (emulator.Cpu.Jns) goto loc_420F93;
			emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
			emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
			emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

			loc_420F93:
			emulator.Cpu.Eax = emulator.Cpu.Sub(emulator.Cpu.Eax, new Register8(0x00/*0*/));
			if (emulator.Cpu.Je) goto loc_421138;
			emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
			if (emulator.Cpu.Jne) goto loc_4212F3;
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B77000/*1085763584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B7E800/*1085794304*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B86000/*1085825024*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B8D800/*1085855744*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B95000/*1085886464*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B9C800/*1085917184*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487092/*4747410*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BA4000/*1085947904*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BAB800/*1085978624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487094/*4747412*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487096/*4747414*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			goto loc_4212EB;

			loc_421138:
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B77000/*1085763584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x04/*4*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B7E800/*1085794304*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B86000/*1085825024*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B8D800/*1085855744*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC092C000/*3230842880*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B95000/*1085886464*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC094A000/*3230965760*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B77000/*1085763584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x004870D2/*4747474*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[new Register32(0x00487520/*4748576*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC094A000/*3230965760*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B7E800/*1085794304*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC094A000/*3230965760*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40B86000/*1085825024*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x00487522/*4748578*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
			emulator.Memory16[new Register32(0x00487524/*4748580*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Memory16[new Register32(0x004870D4/*4747476*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Memory16[new Register32(0x004870D6/*4747478*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));

			loc_4212EB:
			emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x08/*8*/));

			loc_4212F3:
			emulator.Cpu.Push(new Register32(0x004415C8/*4462024*/));
			emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x04/*4*/));
			emulator.Cpu.Edi = emulator.Cpu.Pop32();
			emulator.Cpu.Esi = emulator.Cpu.Pop32();
			return;

		}
	}
}