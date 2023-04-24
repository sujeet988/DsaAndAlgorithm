using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.Sujeet
{
    internal class DictionaryCrud
    {
        readonly Dictionary<int,int> dictionary=new Dictionary<int,int>();
        public Dictionary<int,int> AddItemToDictionary(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                // if item already exists in dictionary then increase count
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++; 
                    /* or 
                    var value = dictionary[arr[i]];
                    dictionary.Remove(arr[i]);
                    dictionary.Add(arr[i], ++value);
                    */

                }
                else
                {
                    //Add  Key with values 1
                    dictionary.Add(arr[i],1);
                }
            }
           return dictionary;
        }

        public void PrintDictionary(Dictionary<int,int> dictionary)
        {
            if (dictionary == null)
            {
                return;
            }
            foreach(var keyvaluepair in dictionary) 
            { 
                Console.WriteLine("Key : {0} and Value : {1}",keyvaluepair.Key, keyvaluepair.Value);
            }
        }
    }
}
