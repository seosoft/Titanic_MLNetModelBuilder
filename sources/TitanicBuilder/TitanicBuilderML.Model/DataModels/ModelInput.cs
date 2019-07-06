//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace TitanicBuilderML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("PassengerId"), LoadColumn(0)]
        public float PassengerId { get; set; }


        [ColumnName("Survived"), LoadColumn(1)]
        public bool Survived { get; set; }


        [ColumnName("Pclass"), LoadColumn(2)]
        public float Pclass { get; set; }


        [ColumnName("Name"), LoadColumn(3)]
        public string Name { get; set; }


        [ColumnName("Sex"), LoadColumn(4)]
        public string Sex { get; set; }


        [ColumnName("Age"), LoadColumn(5)]
        public float Age { get; set; }


        [ColumnName("SibSp"), LoadColumn(6)]
        public float SibSp { get; set; }


        [ColumnName("Parch"), LoadColumn(7)]
        public float Parch { get; set; }


        [ColumnName("Ticket"), LoadColumn(8)]
        public string Ticket { get; set; }


        [ColumnName("Fare"), LoadColumn(9)]
        public float Fare { get; set; }


        [ColumnName("Cabin"), LoadColumn(10)]
        public string Cabin { get; set; }


        [ColumnName("Embarked"), LoadColumn(11)]
        public string Embarked { get; set; }


    }
}
