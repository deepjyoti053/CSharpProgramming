namespace MyFirstWebApplication.Models
{
    public class MyDataViewModel
    {
        public List<DataClass> Datas { get; set;}
    }
    public class DataClass
    {
        public int RollNumber { get; set; }

        public string Name { get; set; }

        public decimal Marks { get; set; }


        public List<DataClass> GetData()

        {
            List<DataClass> listData = new List<DataClass>();
            listData.Add(new DataClass { RollNumber = 1, Name = "Ram", Marks = 75m });
            listData.Add(new DataClass { RollNumber = 4, Name = "AAA", Marks = 89.6m});
            var s = new DataClass { RollNumber=2, Name= "BBB", Marks=98.5m};
            listData.Add(s);

            return listData;
        }
    }
}
