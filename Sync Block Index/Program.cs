using System;

//ref link:https://www.youtube.com/watch?v=iz25OQdRdaE&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=34
//  see project -- what's in the box

// C# --CSC--> MSIL --JIT--> Machine Languange
//  MSIL(MS intermidiate langauge) - boxing/unboxing
//  Machine Languange - Stack/Heap

//  Heap -> 2 extra datamembers -- 1. sync block index - required threading knowledge , 2. type object pointer - requires reflection knowledge
//type object pointer -- allows us and CLR runtime(.NET runtime) to know about the actual type of object at runtime
// parenthetical cast - is/as -- null(as)

/* The following is a brief explanation of what each of
* the x86 general-purpose registers stands
* for: EAX: "Extended Accumulator" - used for arithmetic and logical
* operations, as well as for storing return values from
* functions. EBX: "Extended Base" - often used as a pointer to
* data in the data segment of memory.
 */

// Sync Block Index --

class Cow
{
    public int mooCount;
}

class MainClass
{
    static void Main()
    {
        // Sync Block index -- waste 4 bytes when instantiating an object
        Cow betsy = new Cow();
        betsy.mooCount = 9;
        lock(betsy)     // threading knowledge require
        {
            Console.WriteLine("Whatever");
        }
        
        
        //Type t;
        //object
        //Cow betsy = new Cow();
        //betsy.mooCount = 9;
        //Cow georgy = new Cow();
        //georgy.mooCount = 3;
        //MainClass m = new MainClass();  // SBI/TOP


        ////---------------------


        //Type t;         // reflection knowledge - for Type definition 
        //Cow betsy = new Cow();
        //betsy.GetType();    // type object pointer shares references
        //
        //betsy.mooCount = 9;
        //Cow georgy = new Cow();
        //georgy.mooCount = 3;
        //
        //MainClass m = new MainClass();
    }
}