using _9_paskaita_OOP_generics_praktika;

var myList = new List<string>
{
    "string1",
    "string1",
    "string2",
    "string3",
    "string4"
};



//var readOnlyList = new ReadOnlyList<string>(myList);
//readOnlyList.MakeIntoArray();
//readOnlyList.ShowInside();
//readOnlyList.FindElement("string1");
//readOnlyList.IfTheElementIsThere("string2");


var newList = new List<int>
{
    10,
    20,
    5,
    4
};

var secondList = new SecondExercise<int>();
secondList.AddElement(25);
secondList.AddElement(25);
secondList.AddElement(30);
secondList.AddElement(30);
secondList.AddElement(55);
secondList.AddListOfElements(newList);
//secondList.PrintList();
secondList.RemoveByIndex(1);
secondList.RemoveElement(5);
secondList.RemoveAllInstances(30);
secondList.PrintList();







