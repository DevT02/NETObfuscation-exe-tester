# What is this?
This is a simple exe file made for .NET obfuscation to ensure encryption, mutation, protection, or whatever you want to call it of strings/ints/other types is correct.

# The console should print as follows:

```csharp
100
1000
123
12931
18979
30
9312123132123123
2139812381209312
0.3
12931293.123912
10.2
a,b,c,d,wee
Hello World!
A
True
```
C#:
```csharp
        public int intVar = 100;
        public uint lol = 1000;
        public byte lol2 = 123;
        public short hahsa = 12931;
        public ushort lol3 = 18979;
        public sbyte usa = 30;
        public ulong ha = 9312123132123123;
        public long ajksd = 2139812381209312;
        public decimal extere = 0.3m;
        public double wewe = 12931293.123912;
        public float floatVar = 10.2f;
        public string[] loooooool = { "a", "b", "c", "d", "wee" };
        public string stringVar = "Hello World!";
        public char charVar = 'A';
        public bool boolVar = true;
```
Notes: naming of these vars should not be an issue..

# "Check Key?"
You could theoretically change the key at any point in vs or dnspy, it's only in there for cracking purposes (the key tests obfuscation by challenging the reverser for them to try and get it). The main rule of thumb is that if your key is cracked, its a guarantee that your assembly can be reversed, so most people eventually stop looking at your assembly after grabbing it.

If im not mistaken, the current key is: Ehsduyua782637⚈^Ƿ7ą\ud83d\ude4eƌ♎EHUDjwbnHiudejwhdijin\ud83d\ude08ãEHUDjwbnHiudejwhdijinç¡♕♱ƥńeÃȔŅ⚐`☘X)EHUDjwbnHiudejwhdijinŵmkpnfduwiobdsahfFY#EHUDjwbnHiudejwhdijin;oaidoh

(Note that because of emojis, dnspy is unable to display them, so you will have to edit IL instructions and copy the ldstr to get this string, or you could just use the source code).
