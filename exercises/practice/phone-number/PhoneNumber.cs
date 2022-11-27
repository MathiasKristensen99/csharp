using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private static string _replace;

    public static string Clean(string phoneNumber)
    {
        char[] chars = new char[] {'-', '.', '(', ')'};
        phoneNumber = chars.Aggregate(phoneNumber, (c1, c2) => c1.Replace(c2, ' '));
        phoneNumber = phoneNumber.Replace(" ", "");

        return phoneNumber;
    }
}