using System;

public class HashTable
{
	private string[] table;

	public HashTable()
	{
		table = new string[256];
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
		for (int i = 0; i < word.Length; i++)
		{
			hash = hash ^ (hash << 5) ^ (hash >> 2) ^ word[i];
		}
		return Math.Abs(hash) % 256;
	}
}