namespace MyHashTable;

public class HashTable
{
	Dictionary<byte, string> table = new();

	public byte Add(string word)
	{
		byte hash = GetHash(word);
		table.Add(hash, word);
		return hash;
	}

	public string Get(byte hash)
	{
		return table[hash];
	}

	private byte GetHash(string word)
	{
		return (byte)word.Length;
	}
}