namespace MyHashTable;

public class HashTableTests
{
	[Fact]
	public void Add_Get_String()
	{
		var table = new HashTable(100);

		string word = "hello";
		byte hash = table.Add(word);

		string result = table.Get(hash);

		Assert.Equal(word, result);
	}

	[Fact]
	public void Get_NonExistentKey_ReturnsNull()
	{
		var table = new HashTable(100);

		string result = table.Get(10);

		Assert.Null(result);
	}

	[Fact]
	public void Add_DifferentStrings_NoCollision()
	{
		var table = new HashTable(100);

		table.Add("hello");
		table.Add("world");

		string word1 = table.Get(table.Add("hello"));
		string word2 = table.Get(table.Add("world"));

		Assert.Equal("hello", word1);
		Assert.Equal("world", word2);
	}

	[Fact]
	public void HashTable_FilledToCapacity_Succeeds()
	{
		var table = new HashTable(3);

		table.Add("a");
		table.Add("b");
		table.Add("c");

		string a = table.Get(table.Add("a"));
		string b = table.Get(table.Add("b"));
		string c = table.Get(table.Add("c"));

		Assert.Equal("a", a);
		Assert.Equal("b", b);
		Assert.Equal("c", c);
	}
}