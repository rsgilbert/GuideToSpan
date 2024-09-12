using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

readonly ref struct MySpan<T> 
{
    private readonly ref T _reference ;
    private readonly int _length;

    public MySpan(ref T reference)
    {
        _reference = ref reference;
        _length = 1;
    }

    public int Length => _length;
    public MySpan(ref T reference, int length)
    {
        _reference = ref reference;
        _length = length;
    }
    public MySpan(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array);
        _reference = ref array[0];
        // _reference = ref MemoryMarshal.GetArrayDataReference(array);
        _length = array.Length;
    }

    public ref T this[int index]
    {
        get 
        {
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            if((uint) index >= (uint) _length)
            {
                throw new IndexOutOfRangeException();
            }
            return ref Unsafe.Add(ref _reference, index);
        }
    }

    public MySpan<T> Slice(int offset)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(offset);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(offset, _length);
        int newLength = _length - offset;
        return new MySpan<T>(ref Unsafe.Add(ref _reference, offset), newLength);
    }
}