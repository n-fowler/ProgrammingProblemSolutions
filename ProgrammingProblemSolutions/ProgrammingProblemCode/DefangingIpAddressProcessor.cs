namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class DefangingIpAddressProcessor
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
