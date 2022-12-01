namespace WinFormsApp2
{
    public class MyParameter
    {
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }

        public MyParameter()
        {

        }

        public MyParameter(string name, object value)
        {
            ParameterName = name;
            ParameterValue = value;
        }
    }
}
