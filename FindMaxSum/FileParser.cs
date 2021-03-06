using System;
using System.Collections.Generic;
using System.Globalization;

namespace FindMaxSum
{
    public class FileParser
    {
        public static int GetNumberOfMaxLineIn (string [] textByLinesArray, List<int> badLinesNumberList)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            
            int numberOfMaxSumLine = 0;
            double sumOfMembersEachLine = 0.0;

            for (int numberOfLine=0; numberOfLine < textByLinesArray.Length; numberOfLine++)
            {
                double localSum = 0.0;
                var line = textByLinesArray[numberOfLine].Split(',');
                double[] localDoubleArray = new double[line.Length];
                                
                    for (int i=0; i < line.Length; i++)
                    {
                   
                    bool parseResult = Double.TryParse(line[i].Trim(), NumberStyles.AllowDecimalPoint, provider, out localDoubleArray[i]);
                        
                    if (parseResult)
                        {
                            localSum += localDoubleArray[i];
                        }
                    else
                        {
                        localSum = 0;
                        badLinesNumberList.Add(numberOfLine + 1);
                        break;
                        }
                    }
              
                if(localSum > sumOfMembersEachLine)
                {
                    sumOfMembersEachLine = localSum;
                    numberOfMaxSumLine = numberOfLine + 1;
                }

            }
            return numberOfMaxSumLine;
        }

      
    }
}
