using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetails
/// </summary>
/// 
[Serializable]
public class UserDetails
{
    
    public string namestr{ get; private set; }

    public string Phoneno { get; private set; }
    public int age{ get; private set; }
    public string address { get; private set; }
    public string MasterCard { get; private set; }
    
	public UserDetails(string name, string address, string Phoneno, int age, string masterCard)
	{
        this.namestr = name;
        this.address = address;
        this.Phoneno = Phoneno;
        this.age = age;
        this.MasterCard = masterCard;
		//
		// TODO: Add constructor logic here
		//
        


	}
}