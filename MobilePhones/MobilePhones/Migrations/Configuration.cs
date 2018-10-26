namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MobilePhones.Data;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MobilePhonesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MobilePhonesContext context)
        {
            context.Brands.AddOrUpdate(b => b.Name, new Brand[]
            {
                new Brand
                {
                    Name = "Samsung",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Samsung Galaxy Note 9",
                            Dimensions="161.9 x 76.4 x 8.8 mm",
                            Weight=201,
                            ScreenSize=6.40m,
                            Resolution="1440 x 2960 pixels, 18.5:9 ratio (~516 ppi density)",
                            Processor="Qualcomm SDM845 Snapdragon 845 (10 nm)",
                            Memory="512 GB, 8 GB RAM or 128 GB, 6 GB RAM",
                            OS="Android 8.1 (Oreo)",
                            Price=1000.00m,
                            Video="FTLvuDCUQOQ",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="note9-1.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "Huawei",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Huawei P20 Pro",
                            Dimensions="155 x 73.9 x 7.8 mm",
                            Weight=180,
                            ScreenSize=6.10m,
                            Resolution="1080 x 2240 pixels, 18.7:9 ratio (~408 ppi density)",
                            Processor="Hisilicon Kirin 970 (10 nm)",
                            Memory="256 GB, 8 GB RAM or 128 GB, 6 GB RAM",
                            OS="Android 8.1 (Oreo)",
                            Price=900.00m,
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="p20pro-1.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "Razer",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Razer Phone 2",
                            Dimensions="158.5 x 79 x 8.5 mm",
                            Weight=200,
                            ScreenSize=5.72m,
                            Resolution="1440 x 2560 pixels, 16:9 ratio (~513 ppi density)",
                            Processor="Qualcomm SDM845 Snapdragon 845 (10 nm)",
                            Memory="64 GB, 8 GB RAM",
                            OS="Android 8.1 (Oreo)",
                            Price=1100.00m,
                            Video="khxLE4EBoTc",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="razer2-1.png"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "OnePlus",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="OnePlus 6",
                            Dimensions="155.7 x 75.4 x 7.8 mm",
                            Weight=177,
                            ScreenSize=6.28m,
                            Resolution="1080 x 2280 pixels, 19:9 ratio (~402 ppi density)",
                            Processor="Qualcomm SDM845 Snapdragon 845 (10 nm)",
                            Memory="128/256 GB, 8 GB RAM or 64 GB, 6 GB RAM",
                            OS="Android 8.1 (Oreo)",
                            Price=600.00m,
                            Video="6sqfiBoksqw",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="OnePlus6-1.jpg"},
                                new Photo{FileName="OnePlus6-2.jpg"},
                                new Photo{FileName="OnePlus6-3.jpg"},
                                new Photo{FileName="OnePlus6-4.jpg"},
                                new Photo{FileName="OnePlus6-5.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "Essential",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Essential PH-1",
                            Dimensions="141.5 x 71.1 x 7.8 mm",
                            Weight=185,
                            ScreenSize=5.71m,
                            Resolution="1312 x 2560 pixels (~504 ppi density)",
                            Processor="Qualcomm MSM8998 Snapdragon 835 (10 nm)",
                            Memory="128 GB, 4 GB RAM",
                            OS="Android 7.1 (Nougat)",
                            Price=400.00m,
                            Video="1zPfGfrYsJQ",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="essential-1.jpg"},
                                new Photo{FileName="essential-2.jpg"},
                                new Photo{FileName="essential-3.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "HTC",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="HTC U12+",
                            Dimensions="156.6 x 73.9 x 8.7 mm",
                            Weight=188,
                            ScreenSize=6.00m,
                            Resolution="1440 x 2880 pixels, 18:9 ratio (~537 ppi density)",
                            Processor="Qualcomm SDM845 Snapdragon 845 (10 nm)",
                            Memory="64/128 GB, 6 GB RAM",
                            OS="Android 8.0 (Oreo)",
                            Price=800.00m,
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="htcu12plus-1.jpg"},
                                new Photo{FileName="htcu12plus-2.jpg"},
                                new Photo{FileName="htcu12plus-3.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "Apple",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Apple iPhone 8",
                            Dimensions="138.4 x 67.3 x 7.3 mm",
                            Weight=148 ,
                            ScreenSize=4.7m,
                            Resolution="750 x 1334 pixels, 16:9 ratio (~326 ppi density)",
                            Processor="Apple A11 Bionic (10 nm)",
                            Memory="64/256 GB, 2 GB RAM",
                            OS="iOS 11",
                            Price=1000.00m,
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="iphone8-1.jpg"},
                                new Photo{FileName="iphone8-2.jpg"},
                                new Photo{FileName="iphone8-3.jpg"}
                            }
                        },
                        new Phone
                        {
                            Name="iPhone XS",
                            Dimensions="143.6 x 70.9 x 7.7 mm",
                            Weight=177,
                            ScreenSize=5.80m,
                            Resolution="1125 x 2436 pixels, 19.5:9 ratio (~458 ppi density)",
                            Processor="Apple A12 Bionic (7 nm)",
                            Memory="64/256/512 GB, 4 GB RAM",
                            OS="iOS 12",
                            Price=1000.00m,
                            Video="2ccjWGaZe3k",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="xs-1.jpg"}
                            }
                        }
                    }
                },
                new Brand
                {
                    Name = "Google",
                    Phones = new List<Phone>
                    {
                        new Phone
                        {
                            Name="Google Pixel 2",
                            Dimensions="145.7 x 69.7 x 7.8 mm",
                            Weight=143,
                            ScreenSize=5.0m,
                            Resolution="1080 x 1920 pixels, 16:9 ratio (~441 ppi density)",
                            Processor="Qualcomm MSM8998 Snapdragon 835 (10 nm)",
                            Memory="64/128 GB, 4 GB RAM",
                            OS="Android 8.0(Oreo)",
                            Price=800.19m,
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="pixel2-1.jpg"},
                                new Photo{FileName="pixel2-2.jpg"},
                                new Photo{FileName="pixel2-3.jpg"},
                                new Photo{FileName="pixel2-4.jpg"}
                            }
                        },
                        new Phone
                        {
                            Name="Google Pixel 3",
                            Dimensions="145.6 x 68.2 x 7.9 mm",
                            Weight=148,
                            ScreenSize=5.50m,
                            Resolution="1080 x 2160 pixels, 18:9 ratio(~443 ppi density)",
                            Processor="Qualcomm SDM845 Snapdragon 845(10 nm)",
                            Memory="64/128 GB, 4 GB RAM",
                            OS="Android 9.0(Pie)",
                            Price=800.19m,
                            Video="BJrsmM6aEYE",
                            Photos = new List<Photo>
                            {
                                new Photo{FileName="pixel3-1.jpg"},
                                new Photo{FileName="pixel3-2.jpg"},
                                new Photo{FileName="pixel3-3.jpg"},
                                new Photo{FileName="pixel3-4.jpg"},
                                new Photo{FileName="pixel3-5.jpg"},
                                new Photo{FileName="pixel3-6.jpg"},
                                new Photo{FileName="pixel3-7.jpg"}
                            }
                        }
                    }
                }
            });
            context.SaveChanges();
        }
    }
}
