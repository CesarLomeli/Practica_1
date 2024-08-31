using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1;
public class TratamientoCadenas
{
    public string getIpv6(string ipAddress)
    {
        string[] hexas = ipAddress.Split(':');
        if (hexas[7].Contains("/"))
        {
            hexas[7] = hexas[7].Substring(0, hexas[7].IndexOf("/"));
        }
        return Convert.ToInt32(hexas[0], 16).ToString() + " : " + Convert.ToInt32(hexas[1], 16).ToString() + " : " +
            Convert.ToInt32(hexas[2], 16).ToString() + " : " + Convert.ToInt32(hexas[3], 16).ToString() + " : " +
            Convert.ToInt32(hexas[4], 16).ToString() + " : " + Convert.ToInt32(hexas[5], 16).ToString() + " : " +
            Convert.ToInt32(hexas[6], 16).ToString() + " : " + Convert.ToInt32(hexas[7], 16).ToString();
    }

    public string getIpv4(string ipAddress)
    {
        string[] decimales = ipAddress.Split(".");
        return int.Parse(decimales[0]).ToString("X") + "." + int.Parse(decimales[1]).ToString("X") + "." +
            int.Parse(decimales[2]).ToString("X") + "." + int.Parse(decimales[3]).ToString("X"); 
    } 
}