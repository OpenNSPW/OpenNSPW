// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines;

// scenario_100
internal static class Sub41F570
{
	public static void Call(Emulator emulator)
	{
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Esp);
		emulator.Cpu.Esp = emulator.Cpu.And(emulator.Cpu.Esp, new Register8(0xF8/*-8*/));
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x10/*16*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(emulator.Cpu.Ebp);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(new Register16(0x0001/*1*/));
		emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
		emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0xC0A77000/*3232198656*/));
		emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0xC0A13000/*3231789056*/));
		emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x0000D6D8/*55000*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0AB5800/*3232454656*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC08F4000/*3230613504*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x407F4000/*1082081280*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40A77000/*1084715008*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x408F4000/*1083129856*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC09F4000/*3231662080*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x04/*4*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0640000/*3227779072*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0904000/*3230679040*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0F/*15*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0xC0B6A800/*3233196032*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register32(0x40B54000/*1085620224*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x0C/*12*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Ebp = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Eax = emulator.Cpu.And(emulator.Cpu.Eax, new Register32(0x80000001/*2147483649*/));
		if (emulator.Cpu.Jns) goto loc_41F67F;
		emulator.Cpu.Eax = emulator.Cpu.Dec(emulator.Cpu.Eax);
		emulator.Cpu.Eax = emulator.Cpu.Or(emulator.Cpu.Eax, new Register8(0xFE/*-2*/));
		emulator.Cpu.Eax = emulator.Cpu.Inc(emulator.Cpu.Eax);

	loc_41F67F:
		if (emulator.Cpu.Jne) goto loc_41F6B2;
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)] = emulator.Cpu.Mov(new Register32(0x40A77000/*1084715008*/));
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00001770/*6000*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Edx = emulator.Cpu.Sub(emulator.Cpu.Edx, new Register32(0x00000FA0/*4000*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		goto loc_41F6E2;

	loc_41F6B2:
		emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
		emulator.Cpu.Cdq();
		emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00001770/*6000*/));
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)] = emulator.Cpu.Mov(new Register32(0xC0AF4000/*3232710656*/));
		emulator.Cpu.Idiv(emulator.Cpu.Ecx);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000BB8/*3000*/));
		emulator.Cpu.Eax = emulator.Cpu.Sub(emulator.Cpu.Eax, emulator.Cpu.Edx);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();

	loc_41F6E2:
		emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000014/*20*/)]);
		emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
		emulator.Cpu.Ecx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Push(emulator.Cpu.Ecx);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(new Register8(0x06/*6*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x08/*8*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Push(new Register8(0x11/*17*/));
		emulator.Cpu.Push(new Register8(0x01/*1*/));
		emulator.Cpu.Push(emulator.Cpu.Ebx);
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(new Register8(0x07/*7*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000068/*104*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
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
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000004C/*76*/)]);
		emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000048/*72*/)]);
		emulator.Cpu.Push(emulator.Cpu.Edx);
		emulator.Cpu.Push(emulator.Cpu.Eax);
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000058/*88*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
		emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
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
		emulator.Cpu.Push(new Register8(0x03/*3*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
		emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Push(new Register32(0x4060E000/*1080090624*/));
		emulator.Cpu.Push(new Register8(0x00/*0*/));
		emulator.Cpu.Push(emulator.Cpu.Esi);
		emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
		emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fadd(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
		emulator.Cpu.Push(emulator.Cpu.Edi);
		emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
		emulator.Memory64[emulator.Cpu.Esp] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
		emulator.Cpu.Fpu.Stack.Pop();
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Push(new Register8(0x02/*2*/));
		emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
		emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Cpu.Eax = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
		emulator.Cpu.Push(new Register32(0x004415B0/*4462000*/));
		emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
		emulator.Memory16[new Register32(0x00487066/*4747366*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
		emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
		emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x24/*36*/));
		emulator.Cpu.Edi = emulator.Cpu.Pop32();
		emulator.Cpu.Esi = emulator.Cpu.Pop32();
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		emulator.Cpu.Ebx = emulator.Cpu.Pop32();
		emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
		emulator.Cpu.Ebp = emulator.Cpu.Pop32();
		return;

	}
}
