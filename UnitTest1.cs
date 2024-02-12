namespace MyHashTable;

public class HashTableTests
{
	private HashTable hashTable;

	public HashTableTests()
	{
		hashTable = new HashTable();
	}

	[Fact]
	public void Add_ShouldStoreWordAndReturnItsHash()
	{
		string word = "test";

		byte hash = hashTable.Add(word);
		string retrievedWord = hashTable.Get(hash);

		Assert.Equal(word, retrievedWord);
	}

	[Fact]
	public void Get_ShouldRetrieveCorrectWordByHash()
	{
		string word = "retrieve";
		byte hash = hashTable.Add(word);

		string retrievedWord = hashTable.Get(hash);

		Assert.Equal(word, retrievedWord);
	}

	[Fact]
	public void Get_ShouldReturnNullForUnknownHash()
	{
		byte hash = 0;

		string retrievedWord = hashTable.Get(hash);

		Assert.Null(retrievedWord);
	}

	[Fact]
	public void Add_ShouldHandleCollisions()
	{
		string word1 = "collision1";
		string word2 = "collision2";
		byte hash1 = hashTable.Add(word1);
		byte hash2 = hashTable.Add(word2);

		Assert.Equal(word1, hashTable.Get(hash1));
		Assert.Equal(word2, hashTable.Get(hash2));
	}
}