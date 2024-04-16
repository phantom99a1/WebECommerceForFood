﻿namespace BinhDinhFoodWeb.Models
{
    public class Bar
    {
        public string type = "bar";

        public Data data;
        public Options options = new Options();


        public class Options
        {
            public Plugins plugins = new Plugins();
            public Scales scales = new Scales();
            public class Plugins
            {
                public Title title = new Title();
                public class Title
                {
                    public bool display = true;
                    public string text;
                }
            }
            public class Scales
            {
                public Y y = new Y();
                public class Y
                {
                    public bool beginAtZero = true;
                }
            }
        }
        public class Data
        {
            public string[] labels;
            public Dataset[] datasets = new Dataset[1];
            public class Dataset
            {
                public string label;
                public string[] backgroundColor;// = new string[2]
                public string[] borderColor;
                public int borderWidth = 1;
                public float[] data;
                public Dataset(int soLuong)
                {
                    this.backgroundColor = new string[soLuong];
                    this.borderColor = new string[soLuong];
                    this.data = new float[soLuong];
                }
            }
            public Data(int soLuong)
            {
                if(soLuong>0)
                {
                    this.labels = new string[soLuong];
                    this.datasets = new Dataset[1];
                    this.datasets[0] = new Dataset(soLuong);
                }
            }
        }
        public Bar(int soLuong)
        {
            this.data = new Data(soLuong);
        }
    }
}
