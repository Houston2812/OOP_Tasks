using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chain_Of_Responsibility;

public interface IHandler
{  
    IHandler SetNext(IHandler handler);
    IHandler SetPrevious(IHandler handler);

    object Handle(object request);
}



public abstract class AbstractHandler: IHandler
{
    private IHandler _nextHandler;
    private IHandler _previousHandler;

    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    public IHandler SetPrevious(IHandler handler)
    {
        this._previousHandler = handler;
        return handler;
    }

    public virtual object Handle(object request)
    {
        if (this._nextHandler != null)
            return this._nextHandler.Handle(request);
        else if (this._previousHandler != null)
            return this._previousHandler.Handle(request);
        else
            return request.ToString();
    }
}

public class ToLower: AbstractHandler
{
    public override object Handle(object request)
    {
        String data = request.ToString();
        data = data.ToLower();
        return base.Handle(data);
    }
}

public class Multiply: AbstractHandler
{
    public override object Handle(object request)
    {
        String data = request.ToString();
        String overrided = String.Copy(data);
        StringBuilder sb = new StringBuilder();

        int lastIndex = 0;
        while(true)
        {
            String resultString = Regex.Match(overrided, @"\d+").Value;
            if (resultString != String.Empty ) 
            {
                int number = Int32.Parse(resultString) * 2;
               
                sb.Append(data.Substring(lastIndex, data.IndexOf(resultString) - lastIndex));
                sb.Append(number.ToString());
                
                lastIndex = data.IndexOf(resultString) + resultString.Length;
                overrided = overrided.Substring(lastIndex );
            }
            else
            {
                sb.Append(data.Substring(lastIndex));
                break;
            }
        }

        return base.Handle(sb.ToString());
    }
}

public class SanitizeEmails: AbstractHandler
{
    public override object Handle(object request)
    {
        String data = request.ToString();
        StringBuilder overrided = new StringBuilder();

        const string Pattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
        
        Regex emailPattern = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        MatchCollection emailMatches = emailPattern.Matches(data);

        StringBuilder sb = new StringBuilder();
        int lastIndex = 0; 
        foreach (Match emailMatch in emailMatches)
        {
            
            int index = data.IndexOf(emailMatch.Value);

            String email = data.Substring(index, emailMatch.Value.Length);
            sb.Append(data.Substring(lastIndex, index - lastIndex));

            int emailIndex = email.IndexOf("@");
            String domain = email.Substring(emailIndex + 1);

            sb.Append(domain);

            lastIndex = index + emailMatch.Value.Length;
            
        }
        sb.Append(data.Substring(lastIndex));
        
        return base.Handle(sb.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        var lower_ = new ToLower();
        var multiply_  = new Multiply();
        var sanitizeEmails_ = new SanitizeEmails();

        lower_.SetNext(multiply_).SetPrevious(sanitizeEmails_);
        
        String mydata = "r1284 huseyn@gmail.com abdul.abdulov@mail.ru 0984129384 someone-is-good@yahoo.com ADGHFDGFDFGFDSGF";

        Console.WriteLine("Initial string: " + mydata);
        var result = lower_.Handle(mydata);

        Console.WriteLine("Result string:  " + result);
    }
}
