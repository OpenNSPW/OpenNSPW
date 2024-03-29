// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// scenario_104
internal static class Sub4207C0
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
		emulator.Cpu.Push(new Register32(0x40B9F000/*1085927424*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BBD000/*3233533952*/));
		emulator.Cpu.Esi = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
		emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0xC0BBD000/*3233533952*/));
		emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0x40BB8000/*1086029824*/));
		emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x00013880/*80000*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC06E0000/*3228434432*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0904000/*3230679040*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Push(new Register32(0x4073B000/*1081323520*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BAB800/*1085978624*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BAEA00/*3233475072*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx * new Register32(8) + new Register32(0x00491B98/*4791192*/)] = emulator.Cpu.Mov(new Register32(0x00000078/*120*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BAB800/*1085978624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BA8600/*3233449472*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BA0400/*1085932544*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0B9D200/*3233403392*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BA5400/*1085953024*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BB6C00/*3233508352*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(new Register32(0x00000020/*32*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register32(0x406AE000/*1080745984*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B9DC00/*1085922304*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BB1C00/*3233487872*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B97800/*1085896704*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0xC0BAF400/*3233477632*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BA5E00/*1085955584*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register32(0xC0BACC00/*3233467392*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B9FA00/*1085929984*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0xC0BB6C00/*3233508352*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Edi = emulator.Cpu.Or(emulator.Cpu.Edi, new Register8(0xFF/*-1*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_4209F8;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);

	loc_4209F8:
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B8F600/*1085863424*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BB5800/*3233503232*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420A33;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);

	loc_420A33:
		emulator.Cpu.Push(new Register32(0x4070E000/*1081139200*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BA8600/*1085965824*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BB1C00/*3233487872*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420A71;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);

	loc_420A71:
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BA2200/*1085940224*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BAD600/*3233469952*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420AAF;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);

	loc_420AAF:
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B95A00/*1085889024*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0BA9000/*3233452032*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420AED;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);

	loc_420AED:
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0B6A800/*3233196032*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B54000/*1085620224*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC06E0000/*3228434432*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC08B8000/*3230367744*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC06E0000/*3228434432*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0890000/*3230203904*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_420B52;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_420B52:
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x04/*4*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC07B8000/*3229319168*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(4));
		emulator.Cpu.Edx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Edx * new Register32(8) + new Register32(0x00000140/*320*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000003C/*60*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC07B8000/*3229319168*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Memory64[emulator.Cpu.Esp] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0AF4000/*3232710656*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B19400/*1085379584*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x54/*84*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Memory16[new Register32(0x004870D2/*4747474*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Memory16[new Register32(0x00487520/*4748576*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0AF4000/*3232710656*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B22A00/*1085417984*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Memory16[new Register32(0x00487522/*4748578*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0AF4000/*3232710656*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B2C000/*1085456384*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory16[new Register32(0x00487524/*4748580*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004870D4/*4747476*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x004870D6/*4747478*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_420CC7;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_420CC7:
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x04/*4*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40818000/*1082228736*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0xFFFFF2CC/*4294963916*/));
		emulator.Cpu.Eax = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Eax = emulator.Cpu.Shl(emulator.Cpu.Eax, new Register8(0x03/*3*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)] = emulator.Cpu.Mov(emulator.Cpu.Ecx);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000050/*80*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x54/*84*/));
		emulator.Memory16[new Register32(0x0048756A/*4748650*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004879B8/*4749752*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x0048756C/*4748652*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Memory16[new Register32(0x0048756E/*4748654*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_420D52;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_420D52:
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Edx = emulator.Cpu.Mov(new Register32(0x000002D0/*720*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x04/*4*/));
		emulator.Cpu.Ecx = emulator.Cpu.Add(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register32(0xC06E0000/*3228434432*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000028/*40*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000002C/*44*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x0000002C/*44*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000002C/*44*/)]);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Memory16[new Register32(0x00487A02/*4749826*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487E50/*4750928*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487A04/*4749828*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00487A06/*4749830*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x44/*68*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Push(new Register32(0x004415B0/*4462000*/));
		emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		return;

	}
}
