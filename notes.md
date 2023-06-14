# Introduction

You don’t learn to program by reading a book. You will only truly learn if you sit down and program.

C# is a statically typed, garbage collected, objectoriented programming language with imperative, functional, and event-driven aspects.

.NET also includes a pile of code that you can use in your program directly. This collection is called the Base Class Library (BCL).

.NET includes a broad set of tools called a Software Development Kit (SDK) that makes programming life easier.

.NET is an ecosystem. Aside from C#, the three other most popular languages are Visual Basic, F#, and PowerShell.

Namespaces are purely code organization tools, but they are valuable when dealing with hundreds or thousands of classes.

# Types

## Numbers

The computer upgrades them to ints and runs the math as ints, forcing you to then go to the trouble of converting the result back to the smaller type.

To write a binary literal, start your number with a 0b.
For example:
`int thirteen = 0b00001101;`

For a hexadecimal literal, you start your number with 0x:
`int theColorMagenta = 0xFF00FF;`

6022x10^23
`double avogadrosNumber = 6.022e23`

## Strings

If you know the hexadecimal Unicode number for a symbol and would prefer to use that, you can write that out after a \u:
`char aLetter = '\u0061'; // An 'a'`
