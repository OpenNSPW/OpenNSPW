// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// scenario_303
internal static class Sub428020
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Esp);
		emulator.Cpu.Esp = emulator.Cpu.And(emulator.Cpu.Esp, new Register8(0xF8/*-8*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Ebx = emulator.Cpu.Xor(emulator.Cpu.Ebx, emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B6D000/*3233206272*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B4A000/*1085579264*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Esi = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
		emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0x40C13000/*1086402560*/));
		emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0x40790000/*1081671680*/));
		emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x000124F8/*75000*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B6A800/*3233196032*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B54000/*1085620224*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B68000/*3233185792*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B4F000/*1085599744*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x10/*16*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x406C2000/*1080827904*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x4062C000/*1080213504*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C20C00/*1086458880*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory32[new Register32(0x00489FCC/*4759500*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C1F800/*1086453760*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C19400/*1086428160*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x48/*72*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C1BC00/*1086438400*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C1E400/*1086448640*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C20C00/*1086458880*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C23400/*1086469120*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x40568000/*1079410688*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0790000/*3229155328*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40C25C00/*1086479360*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B6DA00/*3233208832*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B61C00/*1085676544*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B6DA00/*3233208832*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Edi = emulator.Cpu.Mov(new Register32(0x00000020/*32*/));
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register32(0x40B6B200/*1085714944*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Eax + emulator.Cpu.Eax * new Register32(4));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Ecx = emulator.Cpu.Lea(emulator.Cpu.Ecx + emulator.Cpu.Ecx * new Register32(8));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x02/*2*/));
		emulator.Cpu.Ecx = emulator.Cpu.Sub(emulator.Cpu.Ecx, emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B9F000/*1085927424*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Ecx = emulator.Cpu.Shl(emulator.Cpu.Ecx, new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register32(0xC0BBD000/*3233533952*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BB8/*4791224*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BBC/*4791228*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[emulator.Cpu.Ecx + new Register32(0x00491BC8/*4791240*/)] = emulator.Cpu.Mov(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40BA4000/*1085947904*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0BC7000/*3233574912*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x408E0000/*1083047936*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0AFE000/*3232751616*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x408E0000/*1083047936*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B04000/*3232776192*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x10/*16*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_4282F1;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_4282F1:
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		if (emulator.Cpu.Je) goto loc_428318;
		emulator.Cpu.Push(new Register32(0x40B9A000/*1085906944*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0BC7000/*3233574912*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40BA9000/*1085968384*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0BC2000/*3233554432*/));
		goto loc_428339;

	loc_428318:
		emulator.Cpu.Push(new Register32(0x40BA9000/*1085968384*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0BC2000/*3233554432*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40B9A000/*1085906944*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0BC7000/*3233574912*/));

	loc_428339:
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory32[new Register32(0x00489FC4/*4759492*/)] = emulator.Cpu.Mov(emulator.Cpu.Edi);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x10/*16*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x38/*56*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0640000/*3227779072*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0890000/*3230203904*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x0B/*11*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory16[new Register32(0x004870D2/*4747474*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487520/*4748576*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004870D4/*4747476*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x004870D6/*4747478*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0A8B000/*3232280576*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B38800/*3232991232*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Memory16[new Register32(0x0048756A/*4748650*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004879B8/*4749752*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0A8B000/*3232280576*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B2F200/*3232952832*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0A8B000/*3232280576*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0B25C00/*3232914432*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x004879BA/*4749754*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x004879BC/*4749756*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x0048756C/*4748652*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0C1F800/*3233937408*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x0048756E/*4748654*/)] = emulator.Cpu.Mov(new Register16(0x0032/*50*/));
		emulator.Memory16[new Register32(0x00487996/*4749718*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Memory16[new Register32(0x00487998/*4749720*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Memory32[new Register32(0x004879F0/*4749808*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x004879F4/*4749812*/)] = emulator.Cpu.Mov(new Register32(0xC0AFE000/*3232751616*/));
		emulator.Memory32[new Register32(0x004879F8/*4749816*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x004879FC/*4749820*/)] = emulator.Cpu.Mov(new Register32(0x408E0000/*1083047936*/));
		emulator.Memory32[new Register32(0x004879E0/*4749792*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x004879E4/*4749796*/)] = emulator.Cpu.Mov(new Register32(0x40790000/*1081671680*/));
		emulator.Memory32[new Register32(0x004879E8/*4749800*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x004879EC/*4749804*/)] = emulator.Cpu.Mov(new Register32(0xC0954000/*3231006720*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x00488332/*4752178*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00488780/*4753280*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0C1F800/*3233937408*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0x4099C800/*1083820032*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x58/*88*/));
		emulator.Memory16[new Register32(0x00488782/*4753282*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00488334/*4752180*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00488336/*4752182*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00002710/*10000*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00001388/*5000*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Eax = emulator.Cpu.Sub(emulator.Cpu.Eax, emulator.Cpu.Edx);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x00487A02/*4749826*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Memory16[new Register32(0x00487E50/*4750928*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(new Register32(0x4062C000/*1080213504*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(new Register32(0x4072C000/*1081262080*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x00487E52/*4750930*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x00487E54/*4750932*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487A04/*4749828*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00487A06/*4749830*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Memory32[new Register32(0x00487E78/*4750968*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00487E7C/*4750972*/)] = emulator.Cpu.Mov(new Register32(0x40790000/*1081671680*/));
		emulator.Memory32[new Register32(0x00487E80/*4750976*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00487E84/*4750980*/)] = emulator.Cpu.Mov(new Register32(0xC0954000/*3231006720*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00001B58/*7000*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40AF4000/*1085227008*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, new Register32(0x00001388/*5000*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000034/*52*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000030/*48*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Memory16[new Register32(0x00487E9A/*4751002*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Memory16[new Register32(0x004882E8/*4752104*/)] = emulator.Cpu.Mov(emulator.Cpu.Di);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x48/*72*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000028/*40*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x18/*24*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40AF4000/*1085227008*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Memory64[emulator.Cpu.Esp] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x0A/*10*/));
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Memory16[new Register32(0x004882EA/*4752106*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487E9C/*4751004*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x00487E9E/*4751006*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F230/*4321840*/));
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
		emulator.Cpu.Push(new Register8(0x05/*5*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00002710/*10000*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00001388/*5000*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Eax = emulator.Cpu.Sub(emulator.Cpu.Eax, emulator.Cpu.Edx);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
		emulator.Memory16[new Register32(0x004887CA/*4753354*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00488C18/*4754456*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register32(0xC0A25C00/*3231865856*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Memory16[new Register32(0x00488C1A/*4754458*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004887CC/*4753356*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Memory16[new Register32(0x004887CE/*4753358*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F490/*4322448*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00001388/*5000*/));
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, new Register32(0x00000DAC/*3500*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000044/*68*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000040/*64*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x48/*72*/));
		emulator.Memory16[new Register32(0x00488C62/*4754530*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x004890B0/*4755632*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00488C64/*4754532*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Memory16[new Register32(0x00488C66/*4754534*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
		emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Call(new Register32(0x00404D80/*4214144*/));
		emulator.Cpu.Push(new Register32(0x004415B0/*4462000*/));
		emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x0C/*12*/));
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		return;

	}
}
