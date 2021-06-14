// Code generated by: https://github.com/OpenNSPW/Disassembler

using Aigamo.Enzan;

namespace OpenNspw.Interop.Subroutines
{
	// scenario_6
	internal static class Sub42B3A0
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
			emulator.Cpu.Ebp = emulator.Cpu.Mov(new Register32(0x00000001/*1*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Memory16[new Register32(0x00489FB0/*4759472*/)] = emulator.Cpu.Mov(new Register16(0x0002/*2*/));
			emulator.Memory16[new Register32(0x00483B4C/*4733772*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Memory32[new Register32(0x00489AB0/*4758192*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489AB4/*4758196*/)] = emulator.Cpu.Mov(new Register32(0x40BC8400/*1086096384*/));
			emulator.Memory32[new Register32(0x00489AB8/*4758200*/)] = emulator.Cpu.Mov(new Register32(0x00000000/*0*/));
			emulator.Memory32[new Register32(0x00489ABC/*4758204*/)] = emulator.Cpu.Mov(new Register32(0xC0A06800/*3231737856*/));
			emulator.Memory32[new Register32(0x00443A48/*4471368*/)] = emulator.Cpu.Mov(new Register32(0x0000D6D8/*55000*/));
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000FA0/*4000*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Edx = emulator.Cpu.Add(emulator.Cpu.Edx, new Register32(0x000007D0/*2000*/));
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
			emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register32(0x40977000/*1083666432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x06/*6*/));
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Memory16[new Register32(0x00486C3A/*4746298*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
			emulator.Memory16[new Register32(0x00487088/*4747400*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register32(0x40951800/*1083512832*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register32(0x4092C000/*1083359232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Memory16[new Register32(0x0048708A/*4747402*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x0048708C/*4747404*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register32(0x40906800/*1083205632*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Memory16[new Register32(0x0048708E/*4747406*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(new Register32(0x408C2000/*1082925056*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487090/*4747408*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000BB8/*3000*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000010/*16*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000FA0/*4000*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Cpu.Eax = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Edx = emulator.Cpu.Add(emulator.Cpu.Edx, new Register32(0x000009C4/*2500*/));
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Edx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000024/*36*/)]);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000001C/*28*/)]);
			emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000018/*24*/)]);
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Edx);
			emulator.Cpu.Push(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x0A/*10*/));
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Memory16[new Register32(0x004870D2/*4747474*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
			emulator.Memory16[new Register32(0x00487520/*4748576*/)] = emulator.Cpu.Mov(emulator.Cpu.Bx);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000068/*104*/)]);
			emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fsub(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
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
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
			emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fsub(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Memory16[new Register32(0x00487522/*4748578*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
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
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000058/*88*/)]);
			emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fsub(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00487524/*4748580*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
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
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Fld(emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
			emulator.Cpu.Fpu.Stack[0] = emulator.Cpu.Fsub(emulator.Cpu.Fpu.Stack[0], new Register64(0x4062C00000000000)/*150*/);
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x20/*32*/));
			emulator.Memory16[new Register32(0x00487526/*4748582*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Esp = emulator.Cpu.Sub(emulator.Cpu.Esp, new Register8(0x08/*8*/));
			emulator.Memory64[emulator.Cpu.Esp] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Memory16[new Register32(0x00487528/*4748584*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x00436056/*4415574*/));
			emulator.Cpu.Cdq();
			emulator.Cpu.Ecx = emulator.Cpu.Mov(new Register32(0x00000FA0/*4000*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Idiv(emulator.Cpu.Ecx);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Edx = emulator.Cpu.Add(emulator.Cpu.Edx, new Register32(0x000007D0/*2000*/));
			emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)] = emulator.Cpu.Mov(emulator.Cpu.Edx);
			emulator.Cpu.Fild(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
			emulator.Memory64[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)] = emulator.Cpu.Fst(emulator.Cpu.Fpu.Stack[0]);
			emulator.Cpu.Fpu.Stack.Pop();
			emulator.Cpu.Edi = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x0000003C/*60*/)]);
			emulator.Cpu.Ebx = emulator.Cpu.Mov(emulator.Memory32[emulator.Cpu.Esp + new Register32(0x00000038/*56*/)]);
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register32(0x409F4000/*1084178432*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Memory16[new Register32(0x0048756A/*4748650*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Memory16[new Register32(0x004879B8/*4749752*/)] = emulator.Cpu.Mov(emulator.Cpu.Si);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x0A/*10*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x08/*8*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x11/*17*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Esi);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x07/*7*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F060/*4321376*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register32(0x409CE800/*1084024832*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x50/*80*/));
			emulator.Memory16[new Register32(0x004879BA/*4749754*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register32(0x409A9000/*1083871232*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Edi);
			emulator.Cpu.Push(emulator.Cpu.Ebx);
			emulator.Cpu.Push(new Register32(0x40983800/*1083717632*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Memory16[new Register32(0x004879BC/*4749756*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x004879BE/*4749758*/)] = emulator.Cpu.Mov(emulator.Cpu.Ax);
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40C09A00/*1086364160*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
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
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40C04F00/*1086344960*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40C00400/*1086325760*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BF7200/*1086288384*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0977000/*3231150080*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BEDC00/*1086249984*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BD4C00/*1086147584*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x05/*5*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esi = emulator.Cpu.Mov(emulator.Cpu.Eax);
			emulator.Cpu.Push(new Register8(0x11/*17*/));
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
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BCB600/*1086109184*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BC2000/*1086070784*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BB8A00/*1086032384*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0xC0A38800/*3231942656*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register32(0x40BAF400/*1085993984*/));
			emulator.Cpu.Push(new Register8(0x00/*0*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041EE20/*4320800*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x40/*64*/));
			emulator.Memory16[new Register32(0x00486C3C/*4746300*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Memory16[new Register32(0x00486C3E/*4746302*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(emulator.Cpu.Ebp);
			emulator.Cpu.Call(new Register32(0x0041F490/*4322448*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Memory16[new Register32(0x004870D4/*4747476*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Memory16[new Register32(0x004870D6/*4747478*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(new Register8(0x02/*2*/));
			emulator.Cpu.Call(new Register32(0x0041F490/*4322448*/));
			emulator.Memory16[new Register32(0x0048756C/*4748652*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Memory16[new Register32(0x0048756E/*4748654*/)] = emulator.Cpu.Mov(emulator.Cpu.Bp);
			emulator.Cpu.Call(new Register32(0x0041F3C0/*4322240*/));
			emulator.Cpu.Push(new Register8(0x03/*3*/));
			emulator.Cpu.Call(new Register32(0x0041F490/*4322448*/));
			emulator.Cpu.Push(new Register32(0x004415F4/*4462068*/));
			emulator.Cpu.Call(new Register32(0x00432A30/*4401712*/));
			emulator.Cpu.Esp = emulator.Cpu.Add(emulator.Cpu.Esp, new Register8(0x1C/*28*/));
			emulator.Cpu.Edi = emulator.Cpu.Pop32();
			emulator.Cpu.Esi = emulator.Cpu.Pop32();
			emulator.Cpu.Ebp = emulator.Cpu.Pop32();
			emulator.Cpu.Ebx = emulator.Cpu.Pop32();
			emulator.Cpu.Esp = emulator.Cpu.Mov(emulator.Cpu.Ebp);
			emulator.Cpu.Ebp = emulator.Cpu.Pop32();
			return;

		}
	}
}