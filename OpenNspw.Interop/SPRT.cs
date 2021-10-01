namespace OpenNspw.Interop;

public sealed class SPRT
{
	public const int Length = 0x28;

	private readonly Memory<byte> _data;

	public SPRT(Memory<byte> data)
	{
		if (data.Length != Length)
			throw new ArgumentException(message: null, paramName: nameof(data));

		_data = data;
	}

	public int no
	{
		get => BitConverter.ToInt32(_data[0x0..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x0..]);
	}

	public int x
	{
		get => BitConverter.ToInt32(_data[0x4..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x4..]);
	}

	public int y
	{
		get => BitConverter.ToInt32(_data[0x8..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x8..]);
	}

	public int cx
	{
		get => BitConverter.ToInt32(_data[0xc..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0xc..]);
	}

	public int cy
	{
		get => BitConverter.ToInt32(_data[0x10..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x10..]);
	}

	public int wd
	{
		get => BitConverter.ToInt32(_data[0x14..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x14..]);
	}

	public int ht
	{
		get => BitConverter.ToInt32(_data[0x18..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x18..]);
	}

	public int base_x
	{
		get => BitConverter.ToInt32(_data[0x1c..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x1c..]);
	}

	public int base_y
	{
		get => BitConverter.ToInt32(_data[0x20..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x20..]);
	}

	public int os_of_x
	{
		get => BitConverter.ToInt32(_data[0x24..].Span);
		set => BitConverter.GetBytes(value).CopyTo(_data[0x24..]);
	}
}
