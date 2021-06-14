using System;

namespace OpenNspw.Interop
{
	public sealed class NEW_PP
	{
		public const int Length = 0x20;

		private readonly Memory<byte> _data;

		public NEW_PP(Memory<byte> data)
		{
			if (data.Length != Length)
				throw new ArgumentException(message: null, paramName: nameof(data));

			_data = data;
		}

		public short used
		{
			get => BitConverter.ToInt16(_data[0x0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x0..]);
		}

		public double x
		{
			get => BitConverter.ToDouble(_data[0x8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x8..]);
		}

		public double y
		{
			get => BitConverter.ToDouble(_data[0x10..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x10..]);
		}

		public bool cls
		{
			get => BitConverter.ToBoolean(_data[0x18..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x18..]);
		}
	}
}
