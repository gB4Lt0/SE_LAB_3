namespace LAB_3_SE
{
    public static class BaseModel
    {
        static double[][] modelTable = new double[3][];
        static double pm = 0;
        static double tm = 0;

        static BaseModel()
        {
            modelTable[0] = new[] { 2.4, 1.05, 2.5, 0.38 };
            modelTable[1] = new[] { 3.0, 1.12, 2.5, 0.35 };
            modelTable[2] = new[] { 3.6, 1.20, 2.5, 0.32 };
        }
        public static double GetEfforts(int codeSize, ProjectType type) 
        {
            pm = modelTable[(int)type][0] * Math.Pow(codeSize, modelTable[(int)type][1]);
            return pm;
        }

        public static double GetTimeToDevelop (ProjectType type) 
        {
            tm = modelTable[(int)type][2] * Math.Pow(pm, modelTable[(int)type][3]);
            return tm;
        }

        public static double GetPersonToDevelop() 
        {
            return pm / tm;
        }

        public static double GetProductivity(int codeSize) 
        {
            return codeSize / pm;
        }

    }
    public enum ProjectType 
    {
        Organic = 0,
        Semi_detached = 1,
        Embedded = 2
    }
}