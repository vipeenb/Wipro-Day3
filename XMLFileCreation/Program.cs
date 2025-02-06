using System.Xml;
using XMLFileCreation;

internal class Program
{
    private static void Main(string[] args)
    {
        Course[] crs = new Course[3];
        crs[0] = new Course() { Cid = 11, CName = "DotnetCore" };
        crs[1] = new Course() { Cid = 12, CName = "Angular" };
        crs[2] = new Course() { Cid = 13, CName = "React" };

        using (XmlWriter xmlw = XmlWriter.Create("course.xml"))
        {
            xmlw.WriteStartDocument();
            xmlw.WriteStartElement("Courses");

            foreach (Course c in crs)
            {
                xmlw.WriteStartElement("Course");
                xmlw.WriteAttributeString("CID", c.Cid.ToString());
                xmlw.WriteElementString("CName", c.CName);
                // Console.WriteLine(c.Cid+" "+c.Name);
                xmlw.WriteEndElement();
            }
            xmlw.WriteEndElement();
            xmlw.WriteEndDocument();
            Console.WriteLine();
        }
    }
}