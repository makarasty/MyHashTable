using MyHashTable;

public class HashTableTests
{
	[Fact]
	public void Add_Word()
	{
		HashTable hashTable = new HashTable();
		string word = "hello";

		byte hash = hashTable.Add(word);

		Assert.Equal((byte)5, hash);
	}

	[Fact]
	public void Get_Hash()
	{
		HashTable hashTable = new HashTable();
		string word = "hello";
		byte hash = hashTable.Add(word);

		string retrievedWord = hashTable.Get(hash);

		Assert.Equal(word, retrievedWord);
	}
}
