using BridgeLabz_Training_AMTPL;
using static BridgeLabz_Training_AMTPL.DelegateExample;
using static BridgeLabz_Training_AMTPL.DelegateExample;
using static BridgeLabz_Training_AMTPL.StruckExample;

Console.WriteLine("Welcome to Address Book ");
int i = 10;
int j = i;

//struct example
position pos = new position(10, 20);
pos.display();

//delegate example - used for user design patterns
DelegateExample del=new DelegateExample();
exampleDelegate exampleDel = new exampleDelegate(del.DisplayMeassage);
   exampleDel("Hello from delegate");

//multicast delegate

exampleDelegate1 exampleDel1 = AddNumbers;
exampleDel1 += AddThreeNumbers;
int result = exampleDel1(10, 20);
Console.WriteLine("Result from multicast delegate: " + result);                 