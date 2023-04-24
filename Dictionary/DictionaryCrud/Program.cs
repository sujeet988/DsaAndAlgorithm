using DsAlgo.Sujeet;
//create array
int[] arr=new int[8] { 1,2,5,5,4,4,4,9};

//Add Item To Dictionary
DictionaryCrud obj=new DictionaryCrud();
var dictionary=obj.AddItemToDictionary(arr);
//Print Dictionary
obj.PrintDictionary(dictionary);