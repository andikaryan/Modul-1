namespace iniProcessor
{
    class Processor
    {
        public string merk;
        public string tipe;
    }
    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "CoreI3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "CoreI5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "CoreI7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RYZEN";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}