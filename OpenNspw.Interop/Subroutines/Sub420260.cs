// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// scenario_103
internal static class Sub420260
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Esp);
		emulator.Cpu.Esp = emulator.Cpu.And(emulator.Cpu.Esp, new Register8(0xF8/*-8*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x14/*20*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0818000/*3229712384*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BC2000/*1086070784*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Ebx = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
		emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0x40BAF400/*1085993984*/));
		emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0xC0640000/*3227779072*/));
		emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x0000D6D8/*55000*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x10/*16*/));
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0840000/*3229876224*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BBD000/*1086050304*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
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
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x09/*9*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0868000/*3230040064*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BC2000/*1086070784*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC082C000/*3229794304*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BCD400/*1086116864*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
		emulator.Cpu.Esi = emulator.Cpu.Or(emulator.Cpu.Esi, new Register8(0xFF/*-1*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_4203A9;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_4203A9:
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0854000/*3229958144*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BCDE00/*1086119424*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_4203E7;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_4203E7:
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC087C000/*3230121984*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BC8E00/*1086098944*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420425;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_420425:
		emulator.Cpu.Push(new Register32(0x40468000/*1078362112*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC08A4000/*3230285824*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BC3E00/*1086078464*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_420463;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_420463:
		emulator.Cpu.Push(new Register32(0x40668000/*1080459264*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC08B8000/*3230367744*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BBBC00/*1086045184*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_4204A2;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_4204A2:
		emulator.Cpu.Push(new Register32(0x40668000/*1080459264*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC08C2000/*3230408704*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40BC0C00/*1086065664*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Cpu.Test(emulator.Cpu.Eax, emulator.Cpu.Eax);
		if (emulator.Cpu.Je) goto loc_4204E1;
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BD8/*4791256*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491754/*4790100*/)] = emulator.Cpu.Mov(emulator.Cpu.Ebx);

	loc_4204E1:
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_4204F2;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_4204F2:
		if (emulator.Cpu.Jne) goto loc_420541;
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000003/*3*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Test(emulator.Cpu.Edx, emulator.Cpu.Edx);
		if (emulator.Cpu.Jne) goto loc_420527;
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)] = emulator.Cpu.Mov(new Register32(0x40B77000/*1085763584*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)] = emulator.Cpu.Mov(new Register32(0x409F4000/*1084178432*/));
		goto loc_420580;

	loc_420527:
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)] = emulator.Cpu.Mov(new Register32(0x40B38800/*1085507584*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)] = emulator.Cpu.Mov(new Register32(0x40B38800/*1085507584*/));
		goto loc_420580;

	loc_420541:
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000FA0/*4000*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00001388/*5000*/));
		emulator.Cpu.Eax = emulator.Cpu.Sub(emulator.Cpu.Eax, emulator.Cpu.Edx);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x000007D0/*2000*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, new Register32(0x00001388/*5000*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();

	loc_420580:
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)]);
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000050/*80*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000060/*96*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000064/*100*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000060/*96*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
		emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000044/*68*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)]);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000068/*104*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)]);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000058/*88*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)]);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory16[new Register32(0x00487092/*4747410*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000058/*88*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x00487094/*4747412*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000020/*32*/)]);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Memory16[new Register32(0x00487096/*4747414*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x00487098/*4747416*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Memory64[emulator.Cpu.Esp] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory16[new Register32(0x0048709A/*4747418*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Cpu.Call(new Register32(0x0041F490/*4322448*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Push(new Register32(0x004415C8/*4462024*/));
		emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x2C/*44*/));
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		return;

	}
}
