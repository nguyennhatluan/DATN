using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ID3_DuBaoThoiTiet
{
    public static class Tree
    {
        public static TreeNode Root { get; set; }

        /// <summary>
        /// Tìm node gốc của tập dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <param name="edge"></param>
        /// <returns></returns>
        private static TreeNode GetRootNodeNew(DataTable data, string edge)
        {
            // Danh sách cột
            var attributes = new List<MyAttribute>();
            var highestInformationGainIndex = -1;
            var highestInformationGain = double.MinValue;

            // Get all names, amount of attributes and attributes for every column             
            for (var i = 0; i < data.Columns.Count - 1; i++)
            {
                var differentAttributenames = MyAttribute.GetDifferentAttributeNamesOfColumn(data, i);
                attributes.Add(new MyAttribute(data.Columns[i].ToString(), differentAttributenames));
            }

            // Calculate Entropy (S)
            var tableEntropy = CaculateEntropyOfTable(data);

            for (var i = 0; i < attributes.Count; i++)
            {
                // Tính information gain cho từng cột
                attributes[i].InformationGain = GetGainForAttribute(data, i, tableEntropy);

                // tìm cột có giá trị information gain lớn nhất
                if (attributes[i].InformationGain > highestInformationGain)
                {
                    highestInformationGain = attributes[i].InformationGain;
                    highestInformationGainIndex = i;
                }
            }

            return new TreeNode(attributes[highestInformationGainIndex].Name, highestInformationGainIndex, 
                attributes[highestInformationGainIndex], edge);
        }

        private static double CaculateEntropyOfTable(DataTable data)
        {
            var totalRows = data.Rows.Count;
            var amountDiffResultValue = GetAmountOfEdgesAndTotalValueResults(data, data.Columns.Count - 1);
            var stepsForCalculation = amountDiffResultValue
                .Select(item => item.Amount / (double)totalRows)
                .Select(division => -division * Math.Log(division, 2))
                .ToList();
            return stepsForCalculation.Sum();
        }

        private static double GetGainForAttribute(DataTable data, int colIndex, double entropyOfDataset)
        {
            // tổng số lượng giá trị của bảng dữ liệu
            var totalRows = data.Rows.Count;
            // Danh sách các value obj khác nhau của từng cột (attribute)
            var amountForDifferentValue = GetAmountOfEdgesAndTotalValueResults(data, colIndex);

            // Information Gain của 1 Attribute
            double gain = 0.0;
            // Entropy của 1 Attribute
            double entropy = 0.0;
            // List đã loại bỏ những giá trị có số lượng = 0
            foreach (var item in amountForDifferentValue)
            {
                var coolDivision = item.Amount == 0 || item.CoolAmount == 0 ? 1 : item.CoolAmount / (double)item.Amount;
                var sunnyDivision = item.Amount == 0 || item.SunnyAmount == 0 ? 1 : item.SunnyAmount / (double)item.Amount;
                var rainDivision = item.Amount == 0 || item.RainAmount == 0 ? 1 : item.RainAmount / (double)item.Amount;
                var partlyCloudyDivision = item.Amount == 0 || item.PartlyCloudyAmount == 0 ? 1 : item.PartlyCloudyAmount / (double)item.Amount;
                item.Entropy = -coolDivision * Math.Log(coolDivision, 2) - sunnyDivision * Math.Log(sunnyDivision, 2)
                            - rainDivision * Math.Log(rainDivision, 2) - partlyCloudyDivision * Math.Log(partlyCloudyDivision, 2);

            }

            foreach (var val in amountForDifferentValue)
            {
                entropy += val.Entropy * val.Amount / (double)totalRows;
            }

            gain = entropyOfDataset - entropy;

            return gain;
        }

        private static List<Value> GetAmountOfEdgesAndTotalValueResults(DataTable data, int indexOfColumnToCheck)
        {
            var knownValues = CountKnownValues(data, indexOfColumnToCheck);
            var diffValuesOfColumn = new List<Value>();
            foreach (var item in knownValues)
            {
                var amount = 0;
                var coolAmount = 0;
                var sunnyAmount = 0;
                var rainAmount = 0;
                var partlyCloudyAmount = 0;

                for (var i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i][indexOfColumnToCheck].ToString().Equals(item))
                    {
                        amount++;

                        // Counts the positive cases and adds the sum later to the array for the calculation
                        if (data.Rows[i][data.Columns.Count - 1].ToString().Equals("Cool"))
                        {
                            coolAmount++;
                        }
                        else if (data.Rows[i][data.Columns.Count - 1].ToString().Equals("sunny"))
                        {
                            sunnyAmount++;
                        }
                        else if (data.Rows[i][data.Columns.Count - 1].ToString().Equals("partly cloudy"))
                        {
                            partlyCloudyAmount++;
                        }
                        else
                        {
                            rainAmount++;
                        }
                    }
                }
                var val = new Value()
                {
                    Amount = amount,
                    CoolAmount = coolAmount,
                    SunnyAmount = sunnyAmount,
                    RainAmount = rainAmount,
                    PartlyCloudyAmount = partlyCloudyAmount
                };
                diffValuesOfColumn.Add(val);

            }

            return diffValuesOfColumn;
        }


        private static IEnumerable<string> CountKnownValues(DataTable data, int indexOfColumnToCheck)
        {
            var knownValues = new List<string>();

            // add the value of the first row to the list
            if (data.Rows.Count > 0)
            {
                knownValues.Add(data.Rows[0][indexOfColumnToCheck].ToString());
            }

            for (var j = 1; j < data.Rows.Count; j++)
            {
                var newValue = knownValues.All(item => !data.Rows[j][indexOfColumnToCheck].ToString().Equals(item));

                if (newValue)
                {
                    knownValues.Add(data.Rows[j][indexOfColumnToCheck].ToString());
                }
            }

            return knownValues;
        }

        public static TreeNode Learn(DataTable data, string edgeName)
        {
            //var root = GetRootNode(data, edgeName);

            // new 
            var root = GetRootNodeNew(data, edgeName);

            foreach (var item in root.NodeAttribute.DifferentAttributeNames)
            {
                // if a leaf, leaf will be added in this method
                var isLeaf = CheckIfIsLeaf(root, data, item);

                // make a recursive call as long as the node is not a leaf
                if (!isLeaf)
                {
                    // cuối cùng table chỉ còn lại 1 column thời tiết.
                    var reducedTable = CreateSmallerTable(data, item, root.TableIndex);

                    root.ChildNodes.Add(Learn(reducedTable, item));
                }
            }

            return root;
        }

        private static bool CheckIfIsLeaf(TreeNode root, DataTable data, string attributeToCheck)
        {
            var isLeaf = true;
            var allEndValues = new List<string>();

            // get all leaf values for the attribute in question
            for (var i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][root.TableIndex].ToString().Equals(attributeToCheck))
                {
                    allEndValues.Add(data.Rows[i][data.Columns.Count - 1].ToString());
                }
            }

            // check whether all elements of the list have the same value
            if (allEndValues.Count > 0 && allEndValues.Any(x => x != allEndValues[0]))
            {
                isLeaf = false;
            }

            // create leaf with value to display and edge to the leaf
            if (isLeaf)
            {
                root.ChildNodes.Add(new TreeNode(true, allEndValues[0], attributeToCheck));
            }

            return isLeaf;
        }

        private static DataTable CreateSmallerTable(DataTable data, string edgePointingToNextNode, int rootTableIndex)
        {
            var smallerData = new DataTable();

            // add column titles
            for (var i = 0; i < data.Columns.Count; i++)
            {
                smallerData.Columns.Add(data.Columns[i].ToString());
            }

            // add rows which contain edgePointingToNextNode to new datatable
            for (var i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][rootTableIndex].ToString().Equals(edgePointingToNextNode))
                {
                    var row = new string[data.Columns.Count];

                    for (var j = 0; j < data.Columns.Count; j++)
                    {
                        row[j] = data.Rows[i][j].ToString();
                    }

                    smallerData.Rows.Add(row);
                }
            }

            // remove column which was already used as node            
            smallerData.Columns.Remove(smallerData.Columns[rootTableIndex]);

            return smallerData;
        }

        public static string CalculateResult(TreeNode root, IDictionary<string, string> valuesForQuery,string description)
        {
            var valueFound = false;
            description += root.Name.ToUpper() + " -- ";

            if (root.IsLeaf)
            {
                MainHandler.Result = root.Name.ToUpper();
                description = root.Edge.ToLower() + " --> " + root.Name.ToUpper();
                
                valueFound = true;
            }
            else
            {
                foreach (var childNode in root.ChildNodes)
                {
                    
                    foreach (var entry in valuesForQuery)
                    {
                        if (childNode.Edge.ToUpper().Equals(entry.Value.ToUpper()) && root.Name.ToUpper().Equals(entry.Key.ToUpper()))
                        {
                            valuesForQuery.Remove(entry.Key);
                            
                            return description + CalculateResult(childNode, valuesForQuery, $"{childNode.Edge.ToLower()} --> ");
                        }
                        
                        
                    }

                    
                }
                
            }

            // if the user entered an invalid attribute
            if (!valueFound)
            {
                MainHandler.Result = "not found";
                if (valuesForQuery.ContainsKey(root.Name))
                    description += valuesForQuery[root.Name] + " --> ";
                description += "Attribute not found";
            }

            return description;
        }
    }
}
