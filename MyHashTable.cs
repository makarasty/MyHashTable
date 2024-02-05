namespace MyHashTable;

public class HashTable
{
	private string[] table;
	private int size;

	public HashTable(int size)
	{
		this.size = size;
		table = new string[size];
	}

	public byte Add(string word)
	{
		int hash = PearsonHash(word);
		table[hash] = word;
		return (byte)hash;
	}

	public string Get(byte hash)
	{
		return table[hash];
	}

	private int PearsonHash(string word)
	{
		int hash = 0;
		foreach (char c in word)
		{
			hash = hash * 33 + c;
		}
		return Math.Abs(hash) % size;
	}
}