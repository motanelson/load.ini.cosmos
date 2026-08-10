class inifiles


{
    static String Mains = "main"; static String Value = "ok";

    static void Writes()
    {

        Console.WriteLine(Value);


    }
    public static String[] initLoad(String files)
    {
        int l1 = 0;
        int l2 = 0;
        String[] s = { };
        String[] ss = { };
        s = File.ReadAllLines(files);
        foreach (String s2 in s)

        {
            Value = s2;
            l1 = s2.IndexOf('[') + 1;
            l2 = s2.IndexOf("]");
            if (!(l1 < 1))
            {
                if (l2 > -1) Mains = s2.Substring(l1, l2 - l1).Trim().Replace(" ", "_");
                else
                {
                    Value = "error:";
                    Writes();
                    

                }
            }
            else
            {
                Value = Mains + "/" + s2.Trim();
                Array.Resize(ref ss, ss.Length + 1);
                ss[ss.Length - 1]=Value;

            }

        }

        return ss;
    }



}






class loadtini

{
    static void Writes(String Value)
    {

        Console.WriteLine(Value);


    }
    public static void Main(String[] argv)
    {


        int lens = argv.Length;
        String s = "";
        String[] ss =  { };
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        if (lens > 0)

        {
            s = argv[0];
            ss=inifiles.initLoad(s);
        }
        else
            Console.WriteLine("give me file name ");


   
    foreach (String s2 in ss)
    {
        Writes(s2);
    }
 }

}
