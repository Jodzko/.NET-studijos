using _7_paskaita_OOP_Generics;

var genericMethods = new GenericMethods();

genericMethods.ShowItem<string>("string");
genericMethods.ShowItem<int>(250);
genericMethods.GetTypeName<GenericMethods>(new GenericMethods());

var myList = new MySelfMadeList<int>();
myList.AddItem(250);
myList.AddItem(150);
myList.AddItem(350);
myList.AddItem(550);
myList.AddItem(550);
myList.AddItem(550);
myList.AddItem(550);
myList.AddItem(550);
myList.AddItem(550);
myList.AddItem(450);
myList.RemoveItem(450);

var input = "";
var input2 = 25;
Validation.Validate<string>(Console.ReadLine());
Validation.Validate(input);
Validation.Validate(input2);
//Validation.Validate<string>(null);

genericMethods.ShowValues(input, input2);
