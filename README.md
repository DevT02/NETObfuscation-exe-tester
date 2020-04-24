# NETObfuscation-exe-tester
This is a simple exe file made for .NET obfuscation to ensure encryption, mutation, protection, or whatever you want to call it of strings/ints/other types is correct.
The console should print as follows:

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
Notes: naming of these vars should not be an issue, an obfuscator that does not rename has a mental problem.
