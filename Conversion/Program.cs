//implicit conversion & explicit conversion
//implicit (Automatic)
using System.Data;

byte b = 255;

Int16 i = b;
Int32 i1 = i;
Int64 i2 = i1;//implicit from lower to hinger
//i = i1;//cannot convert from higher to lower


//Explivit Method1 -- Adding Datatype before Veriable
i1 = (Int32)i2;
i = (Int16)i1;
b = (byte)i;
//Method2 using predefinded function called Method
i1 = Convert.ToInt32(i2);
i = Convert.ToInt16(i1);
b = Convert.ToByte(i);

//From 1 to 1.0 or 2.1 to 2
float f = i1;//converted implicitly
i1 = (int)f;//to be converted explivitly
i1 = Convert.ToInt32(f);//1.3 --> 1 & 1.7 ->2

Char c = 'a';//valued type & all the above are valued type variables
int i3 = 'a';
i3 = c;
i1 = c;
c = (char)i3;
string str = "2";
int i4 = Convert.ToInt32(str);

str = Convert.ToString(i);
str = i.ToString();
str = 3.ToString();

bool b1 = Convert.ToBoolean("True");
b1 = Convert.ToBoolean("true");
b1 = Convert.ToBoolean("TRUE");

str = b1.ToString();
str = Convert.ToString(b1);
//Datetype. TryParse out keyword
Console.WriteLine(i2);
