//using System;
//using System.Collections.Generic;

//namespace ObjectCSV
//{
//    public class DataConfig
//    {
//        public List<string> GetModel<T>(T type)
//        {
//            Console.WriteLine("Creating Data Model.");

//            List<string> modelList = new List<string>();

//            foreach (var prop in type.GetType().GetProperties())
//            {
//                modelList.Add(prop.ToString());
//            }

//            var formatedList = FormatModel(modelList);

//            return formatedList;
//        }

//        public List<string> FormatModel(List<string> modelData)
//        {
//            Console.WriteLine("Formating Data Model.");

//            for (int i = 0; i < modelData.Count; i++)
//            {
//                string actualValue = modelData[i];
//                string finalChar = actualValue.Substring(actualValue.IndexOf(" ") + 1);
//                modelData[modelData.FindIndex(x => x.Equals(actualValue))] = finalChar;            
//            }

//            return modelData;
//        }
//    }
//}