# EasyHash

EasyHash contains convenience methods to make it easier to deal with hashes.

The primary utility is the *AnalyzeHashType*, which give a hashed string will determine the hash algorithm used produce it **(MD5, SHA1, SHA256)**

## Examples
### AnalyzeHashType
```csharp
var hashString = "2784168a6211c17c89993cf51050a299";

if (HashType.Md5 == HashAnalyzer.AnalyzeHashType(hashString))
{
    Console.WriteLine("This is an MD5 hash");
}
```
### GenerateHash
```csharp
var textString = "some random bunch of text";

var hashedString = Hasher.GenerateHash(textString,HashTyp.Sha1);
```

