using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Models;

namespace ZooProject.Exceptions;

public class CarerNameException : Exception
{
    public CarerNameException(string carer) : base($"Bakici adi en az 2 karakterli olmalidir! sizin girdiginiz ad : {carer}") { }
    
}
